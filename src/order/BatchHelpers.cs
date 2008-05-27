using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Ready,
            Synced,
            Failed,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 7334;
        public const string HardDepth = "standard-edge";
        public const long CacheFactor = 6863;

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches > (64 + item))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
