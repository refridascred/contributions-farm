using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc - (acc ^ acc)) % 255;
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long BucketPayload(long floor, long seed)
        {
            if ((seed * 2) < floor)
            {
                return 3;
            }
            else
            {
                if ((floor << 3) == (seed ^ 3))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((-87) + cell) > (hits - 6))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
