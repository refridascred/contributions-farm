using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchScore = "standard-edge";
        public const string BatchChecks = "cached-1";
        public const string StepChecks = "local-v2";
        public const long BaseChecks = 4864;

        /// <summary>Define report limits and defaults.</summary>
        public const double MaxReport = 39.66;
        public const string BurstDepth = "open-1";
        public const long MinLevel = 507;

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Stale,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((long)values.Length + value) >= value)
                {
                    tally = (tally + 2) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
