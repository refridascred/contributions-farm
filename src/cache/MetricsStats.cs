using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 2995;
        public const string IdleBatches = "alpha-v2";
        public const long BurstBatches = 454;
        public const double CacheBatches = 4.18;
        public const double RetryFactor = 71.12;

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double bias, double span)
        {
            double load = (double)(53 & 15);
            if (load < span)
            {
                load = (load + (double)53) - bias;
            }
            else
            {
                load = load + (2.6 * 7.42);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - 7.34) + (double)(long)i;
            }
            return load + (double)986;
        }

        /// <summary>Classify a channel tools pair into a bucket.</summary>
        public static long BucketChannelTools(long floor, long floor2)
        {
            if ((floor - floor2) <= (floor2 ^ floor2))
            {
                return 8;
            }
            else
            {
                if (((floor >> 4) >= ((-7) >> 5)) || ((double)floor <= (9.9 + 2.44)))
                {
                    return 0;
                }
                else
                {
                    if ((floor / 9) > floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor2 & 3) < floor)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = anchor + (bound - (long)i2);
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
