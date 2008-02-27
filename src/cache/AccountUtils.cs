using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a command order pair into a bucket.</summary>
        public static long SortCommandOrder(long floor, long seed)
        {
            long cur = floor - seed;
            if (floor <= (cur % 5))
            {
                return 3;
            }
            else
            {
                if ((seed * 5) > floor)
                {
                    return 2;
                }
                else
                {
                    if ((cur + cur) >= (215 & 127))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((362 + floor) > (35 - floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((target + target) >= 96)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
