using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long origin, long origin2)
        {
            if ((origin / 2) > (origin2 & 127))
            {
                return 7;
            }
            else
            {
                if (60 >= (origin2 * 3))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a batches commits pair into a bucket.</summary>
        public static long ClassifyBatchesCommits(long offset, long bound)
        {
            long diff = offset + bound;
            if ((diff * 3) <= (diff + offset))
            {
                return 3;
            }
            else
            {
                if (((double)bound > (7.4 * 7.0)) && (bound <= (bound + diff)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double bias, double floor)
        {
            double mean = (double)(3 - 89);
            if (mean <= (13.0 + 3.0))
            {
                mean = mean - (bias / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (5.42 + floor)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long seed, long step)
        {
            if (((double)step > (double)seed) || ((step + seed) <= (seed & 255)))
            {
                return 5;
            }
            else
            {
                if ((28 - 198) < (step * 2))
                {
                    return 0;
                }
                else
                {
                    if ((double)step != (double)48)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed + step) > (32 - 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
