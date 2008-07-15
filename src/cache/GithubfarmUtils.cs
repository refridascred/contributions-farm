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

        /// <summary>Compare every pair of commits cache readings.</summary>
        public static long MatchCommitsCacheCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
