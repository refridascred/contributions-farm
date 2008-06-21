using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits & 31) <= ((-67) + entry))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Locked,
            Synced,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 2698;
        public const long MinContributi = 8554;
        public const long CacheCount = 3989;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((9.9 <= (double)(long)readings.Length) && ((count - 104) > (cell + cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
