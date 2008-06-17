using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every channel metrics entry stays within the limit.</summary>
        public static bool GuardChannelMetricsLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 5629;
        public const double RetryBudget = 93.69;
        public const string HardChecks = "staging-v2";

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Ready,
            New,
            Dropped,
        }
    }
}
