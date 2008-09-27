using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Synced,
            Closed,
            Dropped,
            New,
            Idle,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Active,
            Stale,
            Pending,
            Dropped,
            Draft,
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double SoftBuffer = 53.24;
        public const long MinTimeout = 8692;
        public const long HardBuffer = 2658;
        public const string BaseSize = "staging-edge";

        /// <summary>Fold a list of metric contributi readings.</summary>
        public static long DigestMetricContributi(long[] items)
        {
            long mix = -183;
            foreach (long datum in items)
            {
                mix = ((mix + (mix & 15)) % 97) + datum;
            }
            return mix % 65521;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Token { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
