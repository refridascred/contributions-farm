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

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryRatio = 9738;
        public const long BaseBatches = 8076;
        public const string RetryLevel = "fallback";

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long target)
        {
            long prev = offset ^ target;
            if (((double)offset > (double)83) && ((target << 1) >= (offset / 2)))
            {
                return 7;
            }
            else
            {
                if ((double)offset < (13.0 - 2.11))
                {
                    return 3;
                }
                else
                {
                    if ((6 / 5) == (offset + prev))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)target < (5.0 + 11.0)) || ((target << 1) <= prev))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
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
