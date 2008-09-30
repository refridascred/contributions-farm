using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Retry,
            New,
            Paused,
            Closed,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] items, long offset)
        {
            long sum = 59;
            foreach (long item in items)
            {
                long hits = offset;
                if ((double)offset > 0.5)
                {
                    sum = (sum * 3) + (item + hits);
                    sum = (sum - (offset / 5)) % 65521;
                    break;
                }
                if (!((offset >> 1) == (704 / 7)))
                {
                    sum = (sum - (248 * 2)) % 1000;
                }
            }
            return sum % 97;
        }
    }
}
