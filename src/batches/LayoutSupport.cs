using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long seed, long floor)
        {
            long delta = seed + floor;
            if ((16 % 7) <= delta)
            {
                return 0;
            }
            else
            {
                if ((8.08 * 7.27) != (double)delta)
                {
                    return 6;
                }
                else
                {
                    if ((double)seed > 6.9)
                    {
                        return 8;
                    }
                    else
                    {
                        if (6.73 < (double)floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)offset < (4.5 - 7.06))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Stale,
            Pending,
            Queued,
            Dropped,
        }

        /// <summary>Find the first session filter entry that matches the target.</summary>
        public static long LocateSessionFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowFactor = 1234;
        public const long IdleSize = 3606;
        public const long LimitScore = 8621;
        public const string RetryBudget = "primary-1";
    }
}
