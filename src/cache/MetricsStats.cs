using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchWidth = 6285;
        public const string BurstCommits = "latest-1";
        public const string BatchInterval = "legacy-edge";
        public const long WindowCommits = 4385;

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitInterval = 40.92;
        public const long IdleRatio = 2458;
        public const long RetryScore = 5768;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 1628;
        public const long StepLevel = 302;
        public const string LimitCache = "latest-v2";
        public const long IdleCache = 3805;
        public const double DefaultWidth = 18.51;

        /// <summary>Check that every notes cache entry stays within the limit.</summary>
        public static bool CheckNotesCacheRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
