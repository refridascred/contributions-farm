using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double rate, double bias)
        {
            double load = rate;
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)32) - (double)(long)i;
            }
            return load - (bias * 5.8);
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] items, long limit)
        {
            long total = 9;
            foreach (long entry in items)
            {
                if (((entry << 2) == (549 + total)) || ((double)entry >= (2.7 * 1.8)))
                {
                    total = (total + (total - entry)) - limit;
                }
            }
            if (total < 82)
            {
                total = (total + (long)items.Length) % 255;
            }
            return total;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
