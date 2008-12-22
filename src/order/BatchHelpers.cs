using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long floor, long offset)
        {
            if ((floor << 1) >= (floor ^ 72))
            {
                return 2;
            }
            else
            {
                if (!((offset ^ floor) < (floor ^ 485)))
                {
                    return 4;
                }
                else
                {
                    if (!(floor >= (floor / 7)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor << 3) == (offset / 7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long ClassifyBatch(long seed, long origin)
        {
            if ((double)seed != (5.7 * 12.0))
            {
                return 8;
            }
            else
            {
                if ((8.7 >= (double)origin) || (0 <= (seed % 3)))
                {
                    return 0;
                }
                else
                {
                    if (!((seed << 2) >= (origin >> 1)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Limit { get; set; }
            public double Count { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
