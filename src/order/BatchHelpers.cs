using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double CacheWidth = 0.65;
        public const long StepReport = 6276;
        public const string WindowReport = "cached-v2";
        public const long BaseSize = 5320;

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
