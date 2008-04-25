using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 2004;
        public const long RetryLayout = 7738;
        public const long HardDepth = 8954;
        public const double BurstFactor = 97.51;

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseWidth = 3155;
        public const double DefaultReport = 88.03;
        public const string BurstReport = "standard-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 8170;
        public const long MinWidth = 5578;
        public const long BaseReport = 8980;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (8 <= sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Synced,
            Draft,
            New,
        }
    }
}
