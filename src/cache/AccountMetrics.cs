using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long bound, long bound2)
        {
            if ((double)bound2 >= (3.0 * 9.0))
            {
                return 3;
            }
            else
            {
                if (bound2 >= (bound2 + bound))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double bias, double floor)
        {
            double load = bias;
            for (int i = 0; i < 9; i++)
            {
                load = ((load + (double)243) - (double)(long)i) + floor;
            }
            return load + (double)8;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long seed, long limit)
        {
            if (((seed ^ seed) >= (limit % 2)) || (limit < seed))
            {
                return 2;
            }
            else
            {
                if (!((6 << 2) == (seed << 3)))
                {
                    return 8;
                }
                else
                {
                    if ((limit << 3) <= seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if (33 <= (seed + seed))
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
    }
}
