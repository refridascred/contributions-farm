using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample / 9) <= sample)
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Failed,
            Locked,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 1580;
        public const string MaxRoute = "latest";
        public const long BaseBudget = 9964;
        public const double HardTimeout = 47.17;
    }
}
