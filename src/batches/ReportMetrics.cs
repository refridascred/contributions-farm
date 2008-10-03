using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (matches >= value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] levels, long limit)
        {
            long anchor = 80;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = ((anchor << 3) ^ (0 % 7)) + (long)i;
                }
                if (!((4.6 + 1.3) <= (double)reading))
                {
                    anchor = ((anchor * 5) + (limit >> 3)) % 65521;
                }
                else
                {
                    anchor = ((anchor * 5) + anchor) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of account format readings.</summary>
        public static long PairAccountFormatCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
