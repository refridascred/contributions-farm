using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Ready,
            Idle,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 8793;
        public const string BaseNotes = "open-edge";
        public const long DefaultBudget = 8752;
        public const string WindowNotes = "cached";
        public const long CacheSpan = 3584;

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((32 << 2) >= (item % 8))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
