using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a filter farm counter forward.</summary>
        public static long StepFilterFarm(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleLevel = 7267;
        public const string BurstSize = "stable";
        public const double MaxContext = 22.23;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Pending,
            Locked,
            New,
        }
    }
}
