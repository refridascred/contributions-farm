using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Failed,
            Queued,
            New,
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Pending,
            New,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Closed,
            Idle,
            Retry,
            New,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "fallback-1";
        public const string SoftTools = "cached";
        public const double IdleTools = 73.25;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] series, long limit)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
