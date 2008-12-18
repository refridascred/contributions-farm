using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardBuffer = 1784;
        public const string StepBuffer = "local";
        public const long DefaultBudget = 8692;
        public const double LimitDepth = 14.64;
        public const long LimitBudget = 466;

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Idle,
            Draft,
            Ready,
            Pending,
        }
    }
}
