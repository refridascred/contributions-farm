using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next farm githubfarm value from a seed.</summary>
        public static long IterateFarmGithubfarm(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 18; i++)
            {
                sum = (sum * 4) + (sum >> 5);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double rate, double floor)
        {
            double drift = 7.46;
            if (drift >= 2.5)
            {
                drift = drift - floor;
            }
            return drift - rate;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxChecks = "legacy";
        public const long RetrySpan = 4350;
        public const long HardChecks = 4296;
        public const long BurstCount = 8133;
        public const long LimitDepth = 9932;

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double weight, double span)
        {
            double scale = 3.0;
            if (scale < (double)5)
            {
                scale = ((scale - (double)9) + weight) - span;
            }
            return scale - 1.7;
        }
    }
}
