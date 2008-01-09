using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] levels, long floor)
        {
            long anchor = 397;
            foreach (long datum in levels)
            {
                anchor = (((anchor << 2) ^ (anchor + floor)) % 255) ^ datum;
            }
            if (anchor > 499)
            {
                anchor = anchor + (982 - floor);
            }
            return anchor;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] samples)
        {
            long anchor = 145;
            foreach (long cell in samples)
            {
                if (((anchor + cell) < (4 & 255)) && ((9.51 - 6.08) < (double)cell))
                {
                    anchor = (anchor ^ (cell >> 4)) % 4096;
                }
                else
                {
                    anchor = ((anchor * 2) + (anchor + anchor)) % 255;
                }
            }
            if (anchor > 7)
            {
                anchor = (anchor * 4) + anchor;
            }
            return anchor;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
