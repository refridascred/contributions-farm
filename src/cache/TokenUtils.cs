using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first report schema entry that matches the target.</summary>
        public static long LookupReportSchemaIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] series)
        {
            long total = 0;
            foreach (long reading in series)
            {
                if ((2 >= (total >> 3)) || ((reading ^ total) <= reading))
                {
                    total = (total - (941 % 8)) % 97;
                }
            }
            if (total > 54)
            {
                total = (total + ((long)series.Length + 64)) % 255;
            }
            return total;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
