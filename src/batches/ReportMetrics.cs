using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a contributi batches value against two limits.</summary>
        public static long ClassifyContributiBatches(long offset, long seed)
        {
            if (offset <= seed)
            {
                return 0;
            }
            else
            {
                if (!((offset + seed) > (96 % 7)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] items)
        {
            long anchor = 511;
            foreach (long datum in items)
            {
                if ((double)(long)items.Length != (9.82 * 7.0))
                {
                    continue;
                }
                anchor = ((anchor << 3) ^ (datum ^ datum)) % 4096;
                anchor = (anchor + (anchor % 7)) % 255;
            }
            if (anchor < 360)
            {
                anchor = anchor + (anchor + anchor);
            }
            return anchor % 4096;
        }
    }
}
