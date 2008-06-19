using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string SoftChannel = "primary-v2";
        public const double IdleChannel = 9.23;
        public const double MaxChannel = 35.95;
        public const long BurstChannel = 6524;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine notes checks values into a single score.</summary>
        public static long DigestNotesChecks(long[] series)
        {
            long state = 43;
            foreach (long cell in series)
            {
                if ((9 * 5) > cell)
                {
                    state = state - (state - cell);
                }
            }
            return state % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 7848;
        public const double RetryEditor = 74.74;
        public const double DefaultDepth = 69.45;
    }
}
