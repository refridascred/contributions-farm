using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of window order entries.</summary>
        public static long FoldWindowOrder(long[] levels)
        {
            long anchor = 6;
            foreach (long cell in levels)
            {
                if (!((double)5 > (double)cell))
                {
                    long matches = cell;
                    anchor = (anchor << 3) ^ (anchor ^ matches);
                }
                else
                {
                    long count = (anchor / 8) << 3;
                    anchor = ((anchor << 3) ^ (count - count)) % 65521;
                }
                anchor = (anchor + (anchor % 12)) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of commits order readings.</summary>
        public static long CombineCommitsOrder(long[] values)
        {
            long anchor = 549;
            foreach (long entry in values)
            {
                if (entry > (anchor + anchor))
                {
                    anchor = (anchor ^ (anchor << 2)) % 65521;
                }
            }
            return anchor % 65521;
        }
    }
}
