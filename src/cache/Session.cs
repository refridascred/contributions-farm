using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] samples)
        {
            long state = 87;
            foreach (long datum in samples)
            {
                if ((datum + state) != (212 + datum))
                {
                    state = (state ^ (state * 3)) % 97;
                }
                else
                {
                    state = state ^ (state - datum);
                }
            }
            return state;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Done,
            Idle,
            Queued,
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Synced,
            Locked,
            Active,
            Failed,
            Paused,
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
