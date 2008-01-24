using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Draft,
            Pending,
            Done,
            Closed,
        }

        /// <summary>Digest a series of support record entries.</summary>
        public static long FoldSupportRecord(long[] levels, long limit)
        {
            long carry = 822;
            foreach (long item in levels)
            {
                carry = ((carry << 3) ^ limit) + item;
            }
            return carry % 4096;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public double Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
