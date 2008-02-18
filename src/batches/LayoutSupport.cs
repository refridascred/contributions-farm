using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of commits entry entries.</summary>
        public static long TotalCommitsEntry(long[] samples)
        {
            long score = 1;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = (score - (long)i) % 255;
                }
                score = ((score << 2) ^ (sample % 64)) % 255;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 1072;
        public const string BaseProfile = "open-edge";
        public const long IdleRatio = 4431;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Stamp { get; set; } = "";
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double StepAlready = 89.7;
        public const long RetryTimeout = 2579;
        public const long DefaultFactor = 6394;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            New,
            Synced,
            Queued,
        }
    }
}
