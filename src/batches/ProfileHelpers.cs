using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 <= gain2)
            {
                gain2 = gain2 - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + floor) + (double)(long)i;
            }
            return gain2 - (double)7;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 3074;
        public const long StepDepth = 6276;
        public const long BurstRatio = 4172;
        public const long SoftRecord = 9456;
        public const long CacheWidth = 6748;

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long limit, long seed)
        {
            long bound = limit - seed;
            if (!((double)bound >= (double)seed))
            {
                return 0;
            }
            else
            {
                if (!(limit <= (limit % 12)))
                {
                    return 1;
                }
                else
                {
                    if (((double)limit <= (6.71 + 3.0)) && (((-3) & 15) <= (limit - bound)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed >> 1) <= 745)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((6.99 + 7.1) < (double)item)
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchScore = "fallback-v2";
        public const double SoftRatio = 21.49;
        public const long BurstContributi = 4530;

        /// <summary>Classify a graph window pair into a bucket.</summary>
        public static long SortGraphWindow(long seed, long limit)
        {
            if ((4.0 * 0.8) <= (double)limit)
            {
                return 5;
            }
            else
            {
                if ((double)seed < 7.1)
                {
                    return 7;
                }
                else
                {
                    if (((limit - seed) < seed) && ((double)seed > 10.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((17.0 - 6.9) < (double)limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
