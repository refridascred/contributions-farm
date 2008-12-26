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

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchCounter = "local-v2";
        public const long RetryInterval = 53;
        public const long MaxCounter = 8343;
        public const long RetryCounter = 4210;
        public const long StepFactor = 3875;
    }
}
