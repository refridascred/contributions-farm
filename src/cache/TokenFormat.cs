using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] levels, long bound)
        {
            long acc = 56;
            foreach (long entry in levels)
            {
                acc = (((acc * 5) + 65) % 65521) + entry;
                if (922 <= (bound + acc))
                {
                    acc = (acc * 4) + acc;
                }
            }
            return acc;
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
