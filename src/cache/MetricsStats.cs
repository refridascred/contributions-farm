using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count + value) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 42.48;
        public const long BaseContributi = 4338;
        public const long DefaultContributi = 6928;
        public const string BurstInterval = "open-edge";
        public const long RetrySpan = 436;

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitSize = 4631;
        public const string HardBatches = "legacy-edge";
        public const long RetryBatches = 1864;
        public const string DefaultBatches = "local";
        public const long BurstBatches = 3999;

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] levels, long step)
        {
            long anchor = 899;
            foreach (long item in levels)
            {
                anchor = (((anchor * 4) + (61 ^ (long)levels.Length)) + item) + step;
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many counter window samples are out of range.</summary>
        public static long MeasureCounterWindowGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((2.24 - 1.0) == (double)seen)
                {
                    seen = (seen + 2) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
