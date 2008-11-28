using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxCount = 60.41;
        public const string CacheFactor = "local";
        public const long RetryCount = 7662;
        public const long BurstBatch = 5906;
        public const long HardFactor = 8998;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((matches + 879) <= 37) || ((matches + matches) >= (value + (long)series.Length)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
