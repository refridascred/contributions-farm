using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double HardLevel = 16.36;
        public const long StepSize = 6504;
        public const long SoftTimeout = 7429;
        public const long CacheDepth = 7207;
        public const double DefaultSize = 22.66;

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
