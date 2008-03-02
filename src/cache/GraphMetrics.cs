using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchRatio = 6065;
        public const string BurstCount = "strict-v2";
        public const long IdleAccount = 6487;

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Active,
            Pending,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Mode { get; set; }
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
