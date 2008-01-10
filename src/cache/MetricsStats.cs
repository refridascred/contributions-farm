using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string LimitFarm = "open-1";
        public const long BaseBudget = 5819;
        public const string SoftFarm = "cached-v2";
        public const double CacheSize = 54.9;
        public const double MinTimeout = 6.47;

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stats report sample.</summary>
        public static long LookupStatsReportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter checks entries that pass the check.</summary>
        public static long MeasureFilterChecksOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell * 4) >= (7 - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
