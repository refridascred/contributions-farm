using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell & 63) > (count * 5))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
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
