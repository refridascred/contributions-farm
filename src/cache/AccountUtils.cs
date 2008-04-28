using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long SeriesEditor(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i < (bound ^ 53))
                {
                    result = (result * 3) + (result + (long)i);
                    result = ((result * 5) + (bound >> 5)) % 4096;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Ready,
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 9437;
        public const long WindowGraph = 5462;
        public const long MinGraph = 5648;
        public const double SoftRatio = 88.08;
    }
}
