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

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((5 + sample) < (sample - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 84.75;
        public const long IdleLevel = 5602;
        public const long BurstFactor = 9862;
        public const long SoftBudget = 515;
    }
}
