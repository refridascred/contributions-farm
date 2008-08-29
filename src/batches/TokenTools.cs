using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next already entry value from a seed.</summary>
        public static long RollAlreadyEntry(long limit)
        {
            long total = limit;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 3275;
        public const string BaseBudget = "legacy-v2";
        public const long DefaultTimeout = 1506;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Dropped,
            Paused,
            Pending,
        }
    }
}
