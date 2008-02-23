using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] items, long floor)
        {
            long mark = -628;
            foreach (long cell in items)
            {
                if ((mark * 4) < floor)
                {
                    mark = (mark * 4) + (4 + cell);
                }
            }
            if (mark < 340)
            {
                mark = (mark - mark) % 97;
            }
            return mark % 97;
        }

        /// <summary>Count command record pairs that satisfy a relation.</summary>
        public static long OverlapCommandRecordCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count route support pairs that satisfy a relation.</summary>
        public static long PairRouteSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
