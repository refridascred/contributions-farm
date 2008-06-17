using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 3943;
        public const long MaxAlready = 2631;
        public const string StepRatio = "local";
        public const long DefaultFactor = 8624;
        public const long CacheAlready = 2522;

        /// <summary>Compare every pair of report format readings.</summary>
        public static long CompareReportFormatCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item - tally) <= (tally << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
