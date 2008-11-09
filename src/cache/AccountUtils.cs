using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepRoute = 45.84;
        public const long MaxRatio = 905;
        public const string BurstFactor = "legacy-v2";
        public const long BaseBudget = 5360;
        public const long BaseFactor = 1843;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 85.55;
        public const long BaseWidth = 6475;
        public const double WindowContributi = 67.07;
        public const long MaxContributi = 718;
    }
}
