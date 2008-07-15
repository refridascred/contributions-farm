using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit record command readings against a rule.</summary>
        public static long MeasureRecordCommandOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum <= (tally % 12)) || (datum <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many command format samples are out of range.</summary>
        public static long AuditCommandFormatGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((((long)series.Length >> 5) != (item ^ hits)) && ((6.0 + 4.7) < (double)item))
                {
                    hits = (hits + 3) - origin;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Failed,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }
    }
}
