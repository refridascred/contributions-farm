using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit metric contributi readings against a rule.</summary>
        public static long TallyMetricContributiOutliers(long[] data, long origin)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!((7 + value) <= (3 / 3)))
                {
                    tally = (tally + 3) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 4552;
        public const double SoftLevel = 27.58;
        public const string LimitOrder = "primary";

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((((3 + item) != (item * 4)) || ((double)item <= (double)(-28))) || ((item >> 3) < (hits / 6)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Flag { get; set; }
            public long Mode { get; set; }
            public double Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Owner { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public double Rank { get; set; }
        }
    }
}
