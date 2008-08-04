using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] levels, long floor)
        {
            long acc = -69;
            foreach (long datum in levels)
            {
                acc = (acc - (acc - acc)) - datum;
            }
            if (acc < 8)
            {
                acc = acc + floor;
            }
            return acc;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double HardSize = 93.0;
        public const double BaseInterval = 15.1;
        public const double BaseAlready = 91.81;
        public const string BatchLevel = "staging-1";

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            New,
            Closed,
            Queued,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxWidth = 4474;
        public const string RetryStream = "stable-edge";
        public const string LimitWidth = "open-v2";
        public const long CacheTimeout = 7062;

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double span)
        {
            double drift = ratio;
            return (drift + (double)19) + span;
        }
    }
}
