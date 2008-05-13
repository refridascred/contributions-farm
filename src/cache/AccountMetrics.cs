using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public bool Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Compare every pair of graph commits readings.</summary>
        public static long MatchGraphCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterOutliers(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((sample + hits) == (sample ^ hits)) || ((hits + (long)series.Length) >= (sample << 1)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value / 2) != (value % 8))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
