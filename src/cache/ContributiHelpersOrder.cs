using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Draft,
            Synced,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetrySpan = 1995;
        public const long MinBudget = 7779;
        public const long CacheRoute = 9978;
        public const string MaxTimeout = "strict-1";

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen ^ seen) <= seen)
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }
    }
}
