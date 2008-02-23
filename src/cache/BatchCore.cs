using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] series, long target)
        {
            long carry = 701;
            foreach (long cell in series)
            {
                if (!((double)target >= (double)carry))
                {
                    carry = (carry + (cell + (long)series.Length)) % 1000;
                }
            }
            return carry;
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

        /// <summary>Iterate the channel counter series from a seed.</summary>
        public static long StepChannelCounter(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 3) ^ (38 - (long)i)) % 65521;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
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
