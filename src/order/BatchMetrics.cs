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

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Mode { get; set; }
            public double Limit { get; set; }
        }

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

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            New,
            Failed,
            Ready,
        }
    }
}
