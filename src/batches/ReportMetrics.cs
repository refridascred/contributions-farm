using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit token cache readings against a rule.</summary>
        public static long MeasureTokenCacheOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell <= (seen + seen))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)step == (8.31 * 2.2))
                {
                    tally = (tally + 3) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
