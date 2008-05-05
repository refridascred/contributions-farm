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

        /// <summary>Check that every counter stream entry stays within the limit.</summary>
        public static bool ValidateCounterStreamLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
