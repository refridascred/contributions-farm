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

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 7317;
        public const long StepWindow = 7715;
        public const long StepCount = 4554;
        public const long CacheWindow = 3338;

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
