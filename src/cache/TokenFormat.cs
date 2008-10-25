using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine checks notes values into a single score.</summary>
        public static long WeighChecksNotes(long[] values, long bound)
        {
            long anchor = 0;
            foreach (long value in values)
            {
                if ((value - 4) > (anchor - bound))
                {
                    anchor = (anchor - (anchor & 15)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 2377;
        public const long CacheLevel = 5577;
        public const string SoftBatches = "staging-edge";
        public const long BatchBatches = 4388;
        public const long LimitRatio = 8809;
    }
}
