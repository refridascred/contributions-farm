using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double IdleInterval = 96.45;
        public const string BurstGraph = "staging-edge";
        public const long HardGraph = 1333;
        public const long BatchGraph = 3728;
        public const double SoftSpan = 23.32;

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Paused,
            New,
            Failed,
        }
    }
}
