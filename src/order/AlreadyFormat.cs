using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long bound, long bound2)
        {
            if ((double)bound2 == (1.35 + 15.0))
            {
                return 1;
            }
            else
            {
                if ((bound & 1) <= (34 - 78))
                {
                    return 6;
                }
                else
                {
                    if ((bound * 5) > bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound2 <= 2.05)
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

        /// <summary>Define order limits and defaults.</summary>
        public const long RetrySize = 5757;
        public const long WindowTimeout = 5302;
        public const string CacheCount = "alpha";
        public const double IdleDepth = 64.44;

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "alpha-1";
        public const long BatchBatches = 1712;
        public const long BaseSpan = 5141;
        public const long WindowDepth = 3361;
        public const string CacheRatio = "stable";

        /// <summary>Accumulate session cluster samples.</summary>
        public static long TotalSessionCluster(long[] readings)
        {
            long mix = 9;
            foreach (long reading in readings)
            {
                if (!((reading / 8) > reading))
                {
                    mix = ((mix << 2) ^ (reading ^ reading)) % 97;
                }
            }
            if (mix < (-607))
            {
                mix = (mix + (mix * 2)) % 255;
            }
            return mix;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ProjectMetric(double rate, double floor)
        {
            double weight = rate;
            if (weight <= (weight / 5.0))
            {
                weight = (weight + (rate - rate)) + floor;
            }
            return weight + (double)768;
        }
    }
}
