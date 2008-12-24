using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 4630;
        public const long MinBuffer = 9536;
        public const long DefaultWidth = 5023;

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 1771;
        public const long BatchCount = 2443;
        public const long WindowTimeout = 8175;
        public const long SoftBudget = 7663;

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] series)
        {
            long score = 2;
            foreach (long cell in series)
            {
                score = ((score - (7 << 3)) % 101) ^ cell;
            }
            return score % 97;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double scale, double offset)
        {
            double mean = (double)((-6) & 31);
            if (mean > (double)28)
            {
                mean = (mean + (mean * 8.3)) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - offset) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 4474;
        public const long IdleEditor = 2641;
        public const double WindowFactor = 51.07;
        public const long MinEditor = 2323;
        public const string BaseCount = "fallback-edge";

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long seed, long limit)
        {
            long lane = seed - limit;
            if (lane <= ((-86) % 12))
            {
                return 4;
            }
            else
            {
                if ((seed > limit) && ((lane - limit) < limit))
                {
                    return 3;
                }
                else
                {
                    if (((double)lane <= (3.0 - 4.0)) || ((double)lane != (double)2))
                    {
                        return 7;
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
