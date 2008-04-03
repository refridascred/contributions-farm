using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 6474;
        public const double HardDepth = 4.15;
        public const long BaseToken = 2095;
        public const long HardToken = 1689;
        public const long MinInterval = 9411;

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheReport = "standard-edge";
        public const long IdleReport = 9675;
        public const long BurstReport = 5985;
        public const long MaxReport = 6710;
        public const long IdleScore = 2765;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double weight, double bias)
        {
            double drift = (double)548 - (bias * 8.0);
            if (drift <= (double)971)
            {
                drift = drift + 8.66;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - (weight * 11.0);
        }

        /// <summary>Classify a stats queue pair into a bucket.</summary>
        public static long BucketStatsQueue(long bound, long seed)
        {
            if (((double)seed >= (double)682) && ((17.0 - 5.0) < (double)bound))
            {
                return 4;
            }
            else
            {
                if ((bound & 1) != (bound - seed))
                {
                    return 8;
                }
                else
                {
                    if (((bound / 2) == (seed ^ bound)) || ((double)bound < (double)725))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
