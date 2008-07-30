using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Check that every tools filter entry stays within the limit.</summary>
        public static bool VerifyToolsFilterBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Total { get; set; }
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Closed,
            New,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Dropped,
            Active,
            Done,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MaxInterval = 818;
        public const long StepWidth = 2731;
        public const string MaxLevel = "fallback-v2";

        /// <summary>Define counter limits and defaults.</summary>
        public const string HardTimeout = "cached";
        public const string RetryCounter = "alpha";
        public const double MaxCounter = 89.44;
        public const string LimitCounter = "latest";
    }
}
