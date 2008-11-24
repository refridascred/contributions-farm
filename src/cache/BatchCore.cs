using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseContext = 2520;
        public const string DefaultFactor = "latest";
        public const long MaxContext = 1991;
        public const string RetryContext = "stable-v2";
        public const string CacheContext = "open";

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] readings, long target)
        {
            long score = 837;
            foreach (long sample in readings)
            {
                score = ((score << 3) ^ sample) + target;
            }
            if (score < (-26))
            {
                score = (score - (score + (long)readings.Length)) % 65521;
            }
            return score % 97;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Idle,
            New,
            Synced,
            Pending,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Done,
            Dropped,
            Failed,
        }
    }
}
