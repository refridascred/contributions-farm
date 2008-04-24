using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] series, long floor)
        {
            long mark = -350;
            foreach (long value in series)
            {
                if ((value / 5) == (3 - mark))
                {
                    mark = (mark ^ (value ^ floor)) % 255;
                }
            }
            return mark % 97;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry + matches) < ((long)data.Length + entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxCount = "latest-1";
        public const long MaxTimeout = 8968;
        public const long WindowMetrics = 3625;
        public const double SoftRatio = 22.71;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((7.03 * 8.35) <= (double)item) || ((count * 2) != (item << 2)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
