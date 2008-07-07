using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] samples)
        {
            long state = 488;
            foreach (long datum in samples)
            {
                state = ((state + (state + 77)) % 65521) ^ datum;
            }
            return state % 4096;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double LimitChannel = 30.66;
        public const long DefaultChannel = 9016;
        public const double RetryChannel = 9.52;
        public const double MinChannel = 54.2;

        /// <summary>Measure how many context schema samples are out of range.</summary>
        public static long MeasureContextSchemaHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry % 60) > (entry % 24))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Size { get; set; } = "";
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally - tally) >= 3))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
