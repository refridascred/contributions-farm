using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Ready,
            Stale,
            Paused,
            Active,
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Size { get; set; }
            public long Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count ^ item) >= (item + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Mode { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Locked,
            Dropped,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches + 8) >= (cell + target))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
