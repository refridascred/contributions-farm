using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Draft,
            Synced,
            Stale,
            Retry,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxWidth = 9793;
        public const double StepTimeout = 83.79;
        public const long BurstPayload = 9511;
        public const string RetryPayload = "cached";
        public const long BurstTimeout = 4288;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample - count) < 6)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
