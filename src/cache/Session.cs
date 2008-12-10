using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "cached-1";
        public const long DefaultCounter = 8944;
        public const long IdleCounter = 9540;
        public const string RetryCounter = "latest-v2";

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Closed,
            Synced,
            New,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Queued,
            Dropped,
            Draft,
        }
    }
}
