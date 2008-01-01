using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] series)
        {
            long sum = 52;
            foreach (long datum in series)
            {
                sum = sum + (datum >> 2);
            }
            return sum;
        }

        /// <summary>Combine metrics stats values into a single score.</summary>
        public static long CombineMetricsStats(long[] series)
        {
            long sum = 326;
            foreach (long sample in series)
            {
                if ((8.27 + 9.8) >= (double)sum)
                {
                    sum = sum + (95 + sample);
                }
            }
            return sum;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
            public string Owner { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] series)
        {
            long anchor = 0;
            foreach (long datum in series)
            {
                if (!((anchor - datum) == (datum ^ datum)))
                {
                    anchor = ((anchor * 4) + (datum * 5)) % 97;
                }
            }
            if (anchor > 688)
            {
                anchor = (anchor << 2) ^ anchor;
            }
            return anchor % 4096;
        }
    }
}
