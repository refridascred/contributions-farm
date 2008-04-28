using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Find the first metrics cluster entry that matches the target.</summary>
        public static long FindMetricsClusterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer layout entries.</summary>
        public static long TotalBufferLayout(long[] samples)
        {
            long carry = 641;
            foreach (long item in samples)
            {
                if ((item & 31) >= 80)
                {
                    carry = ((carry * 3) + item) % 1000;
                }
                if ((item * 3) <= (5 * 3))
                {
                    carry = carry ^ (item + item);
                }
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] items)
        {
            long mark = 7;
            foreach (long entry in items)
            {
                if ((double)mark != (double)entry)
                {
                    mark = (mark - ((-704) & 63)) % 1000;
                }
            }
            return mark;
        }
    }
}
