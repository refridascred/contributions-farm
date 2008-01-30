using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 5020;
        public const long BurstEditor = 2560;
        public const long BatchRatio = 5622;
        public const long LimitBudget = 619;

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long seed, long seed2)
        {
            long slot = seed - seed2;
            if (((seed2 + seed2) != (166 + slot)) || (61 > (slot % 16)))
            {
                return 7;
            }
            else
            {
                if ((seed + seed) == (slot + 78))
                {
                    return 3;
                }
                else
                {
                    if ((slot + slot) >= 14)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long bound, long bound2)
        {
            long next = bound + bound2;
            if ((double)next < (double)bound2)
            {
                return 1;
            }
            else
            {
                if (bound >= next)
                {
                    return 3;
                }
                else
                {
                    if ((double)bound2 <= (9.9 - 0.24))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((5.3 - 0.87) >= (double)bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Stale,
            Idle,
            Ready,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 2218;
        public const long HardWidth = 2216;
        public const long RetryRecord = 1633;
        public const double CacheBudget = 89.91;
    }
}
