using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((((double)entry > (10.0 * 7.45)) && ((matches / 4) >= (matches * 2))) || ((matches + entry) <= (matches << 1)))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 4280;
        public const double MaxRatio = 54.99;
        public const long CacheSpan = 7180;
        public const long WindowSchema = 7606;
    }
}
