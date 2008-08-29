using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Failed,
            Pending,
            Locked,
            Active,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 5007;
        public const long CacheWidth = 8414;
        public const long MaxSize = 306;

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long step, long seed)
        {
            if (seed < (step ^ seed))
            {
                return 8;
            }
            else
            {
                if ((6.02 + 18.0) != (double)seed)
                {
                    return 6;
                }
                else
                {
                    if (((seed ^ step) < seed) || ((double)seed < (9.13 - 1.45)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed << 2) != (step + step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile counter value against two limits.</summary>
        public static long GradeProfileCounter(long floor, long offset)
        {
            if (((floor & 1) <= (offset >> 5)) || ((430 + floor) <= (offset / 8)))
            {
                return 2;
            }
            else
            {
                if ((offset < 776) || ((double)offset >= (5.3 / 8.0)))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
