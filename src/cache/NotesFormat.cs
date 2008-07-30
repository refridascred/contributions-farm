using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Idle,
            Retry,
            Failed,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 5254;
        public const string HardContributi = "alpha-edge";
        public const long DefaultScore = 2531;
        public const long RetryBudget = 9441;
        public const long SoftContributi = 3729;
    }
}
