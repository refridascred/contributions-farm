using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 7272;
        public const string BatchStats = "legacy-1";
        public const long RetrySpan = 4903;
        public const long DefaultBudget = 1528;
        public const string MaxStats = "stable";

        /// <summary>Define farm limits and defaults.</summary>
        public const string DefaultCount = "local-v2";
        public const long SoftFarm = 3951;
        public const long BatchFarm = 9085;
        public const long MaxInterval = 8988;

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Synced,
            Queued,
            Idle,
            Done,
        }
    }
}
