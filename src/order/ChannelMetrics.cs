using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell + 761) < (count + 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of graph support entries.</summary>
        public static long TotalGraphSupport(long[] values, long limit)
        {
            long sum = -52;
            foreach (long cell in values)
            {
                sum = (sum * 4) + cell;
                if (((sum >> 4) <= 13) && ((9.0 + 1.99) != (double)limit))
                {
                    sum = (sum + 49) % 97;
                }
            }
            if (sum < 8)
            {
                sum = ((sum << 3) ^ (limit >> 1)) % 255;
            }
            return sum % 1000;
        }
    }
}
