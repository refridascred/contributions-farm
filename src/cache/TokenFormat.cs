using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2347;
        public const double BatchSize = 65.54;
        public const long DefaultDepth = 7420;

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstCount = 4730;
        public const string StepToken = "local-edge";
        public const long DefaultToken = 4301;
        public const string HardScore = "staging-v2";

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Dropped,
            Pending,
            Synced,
            Failed,
        }
    }
}
