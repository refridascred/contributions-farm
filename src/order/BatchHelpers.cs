using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many cache entry samples are out of range.</summary>
        public static long AuditCacheEntryHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (499 >= matches)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Project the next editor value.</summary>
        public static double AdjustEditor(double weight, double bias)
        {
            double bias2 = (double)0 / 7.0;
            if (bias2 < (double)282)
            {
                bias2 = ((bias2 + (double)(-1)) + weight) + bias;
            }
            return bias2 - 8.03;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinInterval = 6738;
        public const long HardReport = 3697;
        public const string DefaultCount = "strict";
        public const long BurstSize = 9249;
    }
}
