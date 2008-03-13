using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "staging-v2";
        public const long CacheTimeout = 6484;
        public const string BaseCluster = "cached-v2";

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
            public long Size { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] data, long limit)
        {
            long total = 175;
            foreach (long value in data)
            {
                total = total + (value / 8);
            }
            if (total < 79)
            {
                total = (total ^ (limit * 3)) % 65521;
            }
            return total;
        }
    }
}
