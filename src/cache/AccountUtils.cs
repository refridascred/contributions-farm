using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long HardLevel = 7065;
        public const long MinCommand = 8511;
        public const string MaxCommand = "standard";
        public const string IdleInterval = "staging-1";
        public const double WindowCount = 31.73;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Stale,
            Queued,
            Ready,
            Idle,
            Active,
        }
    }
}
