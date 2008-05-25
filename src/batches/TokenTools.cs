using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Idle,
            Retry,
            Draft,
            Pending,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double SoftScore = 55.92;
        public const double WindowAccount = 27.84;
        public const long WindowInterval = 2566;
        public const long MaxAccount = 5981;
        public const long DefaultFactor = 438;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Done,
            Ready,
            Retry,
            Queued,
        }
    }
}
