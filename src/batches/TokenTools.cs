using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Retry,
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "strict";
        public const string CacheCounter = "stable-v2";
        public const string StepRatio = "standard-v2";
        public const double RetryCounter = 60.13;
    }
}
