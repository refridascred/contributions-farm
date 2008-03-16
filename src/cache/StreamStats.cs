using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 1241;
        public const double StepProfile = 97.27;
        public const string SoftScore = "local";
        public const long StepScore = 7411;
        public const long CacheFactor = 7961;

        /// <summary>Validate cluster token readings against a bound.</summary>
        public static bool GuardClusterTokenLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Failed,
            Ready,
            Closed,
            Paused,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstInterval = 200;
        public const long RetrySize = 8131;
        public const double BatchDepth = 10.62;
    }
}
