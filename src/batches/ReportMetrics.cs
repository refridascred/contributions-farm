using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry >= 8.28)
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Dropped,
            New,
            Synced,
            Retry,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 5120;
        public const long SoftBuffer = 279;
        public const long IdleBuffer = 4666;
        public const long BaseWidth = 8037;
    }
}
