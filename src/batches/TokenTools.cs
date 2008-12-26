using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate record tools readings against a bound.</summary>
        public static bool VerifyRecordToolsRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Retry,
            Synced,
            Dropped,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitContributi = "local-edge";
        public const string BatchTimeout = "staging";
        public const string CacheContributi = "staging-v2";
    }
}
