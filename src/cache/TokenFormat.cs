using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate cluster editor readings against a bound.</summary>
        public static bool GuardClusterEditorRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Active,
            New,
            Done,
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Paused,
            Synced,
            Failed,
            Idle,
        }
    }
}
