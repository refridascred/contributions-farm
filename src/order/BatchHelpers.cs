using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] series, long step)
        {
            long anchor = 72;
            foreach (long entry in series)
            {
                anchor = anchor + (entry - anchor);
                if ((entry - 55) < (entry ^ entry))
                {
                    anchor = anchor - step;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 4096;
                }
            }
            if (anchor > 1)
            {
                anchor = ((anchor * 5) + (anchor & 31)) % 65521;
            }
            return anchor;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
