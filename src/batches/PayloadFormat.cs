using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Active,
            Locked,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 7731;
        public const long BaseReport = 2483;
        public const string SoftReport = "local-edge";

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Locked,
            Retry,
            Active,
            Synced,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
