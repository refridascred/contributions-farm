using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long seed, long floor)
        {
            long bound = seed ^ floor;
            if ((floor % 16) <= floor)
            {
                return 8;
            }
            else
            {
                if ((6 ^ floor) < seed)
                {
                    return 2;
                }
                else
                {
                    if ((seed ^ 56) == (floor - seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound << 3) > (seed + floor))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many order metric samples are out of range.</summary>
        public static long CountOrderMetricMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen & 63) != (offset + seen))
                {
                    seen = (seen + 1) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Pending,
            Locked,
            Synced,
            Failed,
            Draft,
        }
    }
}
