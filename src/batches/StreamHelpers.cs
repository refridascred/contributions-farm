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

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double weight, double floor)
        {
            double rate = (double)(2 & 63);
            if (rate <= rate)
            {
                rate = ((rate + (0.9 - rate)) + weight) + floor;
            }
            else
            {
                rate = rate + (double)(-386);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate + (rate + 8.62)) + (double)(long)i;
            }
            return rate - (double)95;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] levels, long seed)
        {
            long sum = 485;
            foreach (long value in levels)
            {
                if ((9.5 / 6.0) >= (double)value)
                {
                    sum = (sum + (value - sum)) - seed;
                }
            }
            return sum;
        }
    }
}
