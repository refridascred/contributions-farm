using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches + matches) != (5 >> 3))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long origin, long target)
        {
            long gap = origin + target;
            if ((target << 3) >= (origin - origin))
            {
                return 3;
            }
            else
            {
                if (!((double)gap < 6.9))
                {
                    return 6;
                }
                else
                {
                    if ((double)gap != (2.4 + 10.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (gap <= (81 + target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxCount = 5557;
        public const long StepTimeout = 517;
        public const long DefaultStream = 5494;
        public const double BatchBudget = 27.95;
        public const double HardRatio = 95.88;
    }
}
