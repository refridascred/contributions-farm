using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxTimeout = 7498;
        public const double BurstQueue = 31.39;
        public const string MaxFactor = "latest-1";
        public const long CacheQueue = 5556;
        public const long RetryTimeout = 8763;

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 95;
        public const long HardSession = 2528;
        public const long BatchScore = 1314;
        public const string IdleSession = "stable-v2";

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double weight, double span)
        {
            double rate = span + (double)43;
            if (rate >= (double)8)
            {
                rate = (rate + (double)124) - weight;
            }
            return rate - (rate * 7.3);
        }
    }
}
