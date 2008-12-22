using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate editor command readings against a bound.</summary>
        public static bool GuardEditorCommandBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepWidth = 1204;
        public const double BurstLevel = 66.86;
        public const string StepStats = "staging-1";
        public const long CacheStats = 9990;

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Synced,
            Done,
            Stale,
            Active,
            Draft,
        }
    }
}
