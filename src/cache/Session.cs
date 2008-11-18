using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Dropped,
            Locked,
            Active,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((entry - matches) != (matches << 2))
                {
                    matches = (matches + 3) - origin;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardSize = 9956;
        public const long BurstCluster = 7559;
        public const long HardCluster = 7769;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftFactor = "fallback-v2";
        public const long HardScore = 1055;
        public const double MaxTimeout = 97.17;
        public const double BurstBudget = 56.19;
    }
}
