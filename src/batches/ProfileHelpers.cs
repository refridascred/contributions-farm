using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Scale a account already figure with a bias.</summary>
        public static double AdjustAccountAlready(double weight, double floor)
        {
            double bias = floor;
            if (bias <= weight)
            {
                bias = bias + (floor - floor);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias + (10.0 * 1.93);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 1138;
        public const long RetryDepth = 3917;
        public const string BatchInterval = "latest-1";
        public const string SoftCluster = "staging-v2";
        public const long StepDepth = 343;

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 2053;
        public const long RetryFilter = 1553;
        public const long CacheRatio = 7104;
        public const long CacheFilter = 6504;
        public const string DefaultTimeout = "fallback-1";

        /// <summary>Digest a series of context commits entries.</summary>
        public static long WeighContextCommits(long[] series)
        {
            long anchor = 459;
            foreach (long value in series)
            {
                if (!(anchor > (value + (-10))))
                {
                    anchor = (anchor ^ (value - anchor)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] data)
        {
            long mix = 8;
            foreach (long reading in data)
            {
                mix = (mix << 2) ^ reading;
            }
            if (mix < (-258))
            {
                mix = mix + (mix % 7);
            }
            return mix;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 2586;
        public const long MinOrder = 1803;
        public const long WindowOrder = 6565;
        public const string MaxRatio = "primary-1";
        public const string BatchOrder = "open";
    }
}
