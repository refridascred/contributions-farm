using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Match up cache contributi samples.</summary>
        public static long MatchCacheContributiCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Rank { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long bound, long limit)
        {
            if (!(63 > (limit % 2)))
            {
                return 4;
            }
            else
            {
                if ((bound << 2) == (limit >> 1))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Audit stream contributi readings against a rule.</summary>
        public static long CountStreamContributiMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count / 7) <= (572 >> 5)) || ((14.0 * 2.69) > (double)item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] readings)
        {
            long mark = 14;
            foreach (long cell in readings)
            {
                mark = (mark ^ (mark + cell)) % 97;
                mark = ((mark * 4) + (cell ^ 6)) % 101;
            }
            return mark;
        }
    }
}
