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

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark << 2) ^ (seed + seed)) % 4096;
                mark = (mark * 4) + (seed - seed);
                if (!((mark ^ (long)i) >= (seed ^ mark)))
                {
                    mark = (mark ^ mark) % 1000;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long bound, long floor)
        {
            if (9.94 <= (double)bound)
            {
                return 0;
            }
            else
            {
                if ((2.4 >= (double)floor) && ((floor / 7) > ((-28) * 4)))
                {
                    return 5;
                }
                else
                {
                    if ((17.0 + 9.0) < (double)floor)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((floor << 2) <= bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
