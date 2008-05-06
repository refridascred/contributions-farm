using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a metrics commits counter forward.</summary>
        public static long IterateMetricsCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 21; i++)
            {
                if (!((57 < (floor + anchor)) || ((5.34 - 3.8) <= (double)(long)i)))
                {
                    anchor = ((anchor << 3) ^ (anchor / 6)) % 65521;
                    anchor = (anchor - ((long)i & 1)) % 97;
                }
                if (!!((double)floor < (2.71 * 7.13)))
                {
                    anchor = (anchor << 2) ^ (anchor + floor);
                }
                anchor = (anchor + (long)i) % 4096;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
