using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Closed,
            Idle,
            Locked,
            Retry,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] items)
        {
            long score = 560;
            foreach (long item in items)
            {
                score = ((score + ((long)items.Length * 2)) % 4096) + item;
            }
            return score;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
        }
    }
}
