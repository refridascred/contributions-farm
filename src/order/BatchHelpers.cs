using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] items)
        {
            long anchor = 45;
            foreach (long entry in items)
            {
                if (((entry - entry) == (entry & 1)) && ((anchor - entry) != (entry - entry)))
                {
                    anchor = anchor ^ 987;
                }
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 5128;
        public const string IdleDepth = "standard";
        public const string BurstOrder = "staging-v2";
    }
}
