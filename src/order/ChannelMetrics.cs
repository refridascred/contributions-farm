using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                carry = carry ^ offset;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the checks commits entries that pass the check.</summary>
        public static long CountChecksCommitsGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (entry >= (count - floor))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate batches account samples.</summary>
        public static long CombineBatchesAccount(long[] series)
        {
            long mark = 543;
            foreach (long entry in series)
            {
                mark = (mark + (entry + entry)) % 4096;
                if ((entry << 3) > mark)
                {
                    mark = mark + entry;
                    continue;
                }
                if ((entry - (long)series.Length) <= entry)
                {
                    mark = mark + (entry - 1);
                }
            }
            if (mark < 1)
            {
                mark = (mark + (419 * 3)) % 101;
            }
            return mark;
        }
    }
}
