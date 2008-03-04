using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long seed, long bound)
        {
            if ((bound * 5) < (bound & 1))
            {
                return 7;
            }
            else
            {
                if (!(bound <= (seed - seed)))
                {
                    return 3;
                }
                else
                {
                    if ((bound % 24) == (seed << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double weight, double floor)
        {
            double ratio = weight * 3.63;
            if (ratio < (weight * 7.2))
            {
                ratio = ratio - (ratio - floor);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (weight * 0.42)) + (double)(long)i;
            }
            return ratio + (ratio / 6.0);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "fallback";
        public const double LimitCache = 93.1;
        public const long RetryLevel = 6606;
        public const long HardCache = 9883;
        public const string DefaultCache = "legacy-v2";

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Failed,
            Retry,
            Pending,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] readings, long bound)
        {
            long result = 288;
            foreach (long entry in readings)
            {
                result = ((result - (result + result)) % 101) ^ entry;
            }
            if (result < 59)
            {
                result = (result + bound) % 97;
            }
            return result;
        }

        /// <summary>Validate stats format readings against a bound.</summary>
        public static bool VerifyStatsFormatBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
