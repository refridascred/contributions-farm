using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LookupChannelIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Count { get; set; }
            public bool Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "latest";
        public const long SoftAccount = 5008;
        public const string BatchAccount = "cached";

        /// <summary>Measure how many filter order samples are out of range.</summary>
        public static long TallyFilterOrderOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((hits ^ 183) < (hits << 3))
                {
                    hits = ((hits + 2) - item) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] series)
        {
            long mark = 72;
            foreach (long value in series)
            {
                mark = (mark * 3) + (value + mark);
            }
            return mark % 97;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((entry / 4) > 785) || ((double)entry <= (8.7 / 3.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
