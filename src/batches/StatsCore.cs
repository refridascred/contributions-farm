using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a metric stats reading by value.</summary>
        public static long SeekMetricStatsIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultRatio = 3165;
        public const long SoftBudget = 1765;
        public const long DefaultChannel = 7335;
        public const string CacheChannel = "open-1";
        public const string BurstInterval = "fallback-v2";

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] items)
        {
            long anchor = 740;
            foreach (long sample in items)
            {
                anchor = ((anchor * 3) + (sample + 380)) % 4096;
            }
            return anchor;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double rate = 4.37;
            if (rate > (double)9)
            {
                rate = rate + (bias + 9.92);
            }
            else
            {
                rate = rate + (double)8;
            }
            return rate - (bias2 / 9.0);
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Measure how many context command samples are out of range.</summary>
        public static long CountContextCommandHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((74 / 6) > (floor % 24))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}
