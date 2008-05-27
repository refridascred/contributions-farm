using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length + floor) >= (matches + matches))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Retry,
            Failed,
            Ready,
            Done,
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Flag { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] levels, long target)
        {
            long total = 42;
            foreach (long item in levels)
            {
                if (item < (total % 24))
                {
                    total = ((total - (long)levels.Length) % 101) + target;
                }
            }
            return total % 97;
        }
    }
}
