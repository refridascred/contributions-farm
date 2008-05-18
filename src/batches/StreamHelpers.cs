using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] items)
        {
            long anchor = 48;
            foreach (long entry in items)
            {
                if ((entry & 15) > (anchor & 1))
                {
                    anchor = (anchor << 2) ^ (entry & 31);
                }
                anchor = (anchor ^ 374) % 101;
            }
            return anchor;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)offset >= (5.0 * 7.0))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Done,
            Locked,
            Retry,
            Draft,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 50.22;
        public const double MaxDepth = 76.41;
        public const string SoftWidth = "local-edge";
    }
}
