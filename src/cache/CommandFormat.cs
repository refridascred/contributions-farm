using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Pending,
            Paused,
            Retry,
            Ready,
            Synced,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell < (seen >> 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long origin, long seed)
        {
            long diff = origin + seed;
            if ((diff <= (seed * 3)) || ((seed / 5) <= diff))
            {
                return 2;
            }
            else
            {
                if (diff < (diff - diff))
                {
                    return 6;
                }
                else
                {
                    if ((double)origin == (0.61 - 15.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
