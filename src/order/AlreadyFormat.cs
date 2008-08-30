using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a farm account sample.</summary>
        public static long LookupFarmAccountIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaRange(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double StepSpan = 1.99;
        public const long SoftGraph = 5242;
        public const string CacheGraph = "standard-edge";
        public const string BurstGraph = "alpha-v2";

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportHits(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((origin << 2) != ((long)series.Length >> 3))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultSpan = 4883;
        public const long LimitBatches = 5772;
        public const long RetryBatches = 4919;
        public const long MaxRatio = 19;
        public const long BurstDepth = 4364;
    }
}
