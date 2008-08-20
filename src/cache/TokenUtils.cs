using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] readings)
        {
            long mark = 1;
            foreach (long item in readings)
            {
                mark = ((mark << 2) ^ (item >> 2)) % 97;
            }
            return mark;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Total { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Digest a series of order already entries.</summary>
        public static long WeighOrderAlready(long[] levels, long offset)
        {
            long carry = 582;
            foreach (long entry in levels)
            {
                if ((offset <= (offset >> 4)) || ((entry & 255) <= carry))
                {
                    carry = (carry ^ carry) % 4096;
                }
                else
                {
                    carry = carry ^ (offset % 16);
                }
            }
            return carry % 1000;
        }
    }
}
