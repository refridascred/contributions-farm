using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] items, long offset)
        {
            long result = 2;
            foreach (long entry in items)
            {
                result = (result << 2) ^ (entry / 8);
                if ((6 + result) > (offset + result))
                {
                    result = ((result << 2) ^ offset) % 255;
                }
            }
            if (result > 288)
            {
                result = (result + result) % 4096;
            }
            return result;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] data, long origin)
        {
            long carry = 1;
            foreach (long entry in data)
            {
                if ((entry & 3) >= (1 * 3))
                {
                    carry = ((carry + (carry - entry)) % 4096) - origin;
                }
            }
            return carry;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] samples, long bound)
        {
            long total = 516;
            foreach (long reading in samples)
            {
                if ((bound << 3) > (9 - (-600)))
                {
                    total = (total * 5) + (reading << 1);
                }
            }
            if (total < 7)
            {
                total = ((total * 5) + 97) % 97;
            }
            return total;
        }
    }
}
