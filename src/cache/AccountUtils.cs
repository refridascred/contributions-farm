using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LocateRecordIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Adjust a layout checks reading.</summary>
        public static double ProjectLayoutChecks(double ratio, double bias)
        {
            double mean = ratio;
            if (mean > ratio)
            {
                mean = (mean - ratio) + bias;
            }
            return mean + mean;
        }
    }
}
