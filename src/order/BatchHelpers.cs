using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            New,
            Synced,
            Active,
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] levels)
        {
            long acc = 66;
            foreach (long reading in levels)
            {
                acc = (acc + (9 + acc)) % 4096;
                if (acc < (acc + acc))
                {
                    acc = (acc ^ reading) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 84.75;
        public const long IdleLevel = 5602;
        public const long BurstFactor = 9862;
        public const long SoftBudget = 515;
    }
}
