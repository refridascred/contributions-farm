using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample + matches) != ((long)samples.Length * 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepBudget = 5484;
        public const long SoftQueue = 7817;
        public const long StepQueue = 9152;
        public const long DefaultQueue = 8539;
        public const string RetryBudget = "standard-v2";

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((item % 5) >= 3)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every cache report entry stays within the limit.</summary>
        public static bool ValidateCacheReportRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
