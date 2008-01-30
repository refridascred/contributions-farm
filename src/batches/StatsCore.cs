using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long target, long limit)
        {
            if ((2.0 - 7.32) != (double)limit)
            {
                return 6;
            }
            else
            {
                if ((444 - target) > target)
                {
                    return 0;
                }
                else
                {
                    if ((limit % 16) <= 69)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public bool Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Combine filter batches values into a single score.</summary>
        public static long CombineFilterBatches(long[] readings)
        {
            long sum = 6;
            foreach (long item in readings)
            {
                sum = ((sum ^ (6 & 15)) % 65521) + item;
                if ((double)sum != (3.0 / 2.0))
                {
                    break;
                }
            }
            if (sum < 458)
            {
                sum = ((sum << 2) ^ sum) % 101;
            }
            return sum;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long target, long seed)
        {
            long prev = target ^ seed;
            if (!((10 % 97) <= (11 + prev)))
            {
                return 8;
            }
            else
            {
                if ((prev * 5) != (target + 930))
                {
                    return 3;
                }
                else
                {
                    if (((target % 10) > (-90)) || (target >= (target << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((8.3 - 6.7) <= (double)target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits + hits) != (955 + 3))
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] readings)
        {
            long state = 1;
            foreach (long sample in readings)
            {
                state = ((state ^ (state << 2)) % 1000) ^ sample;
            }
            return state;
        }
    }
}
