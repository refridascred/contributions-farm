using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] series, long step)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((6.6 + 9.36) > (double)step) && (hits >= sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "legacy-1";
        public const string BurstEditor = "cached-v2";
        public const string StepEditor = "local-v2";
        public const long IdleWidth = 7033;

        /// <summary>Check that every profile farm entry stays within the limit.</summary>
        public static bool VerifyProfileFarmRange(long[] samples, long offset)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
