using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long floor, long origin)
        {
            long gap = floor + origin;
            if ((10.0 * 8.81) < (double)floor)
            {
                return 1;
            }
            else
            {
                if (gap < (floor % 24))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long score = 25;
            foreach (long datum in series)
            {
                if (datum > (score ^ 1))
                {
                    score = (score << 3) ^ datum;
                }
            }
            return score % 1000;
        }
    }
}
