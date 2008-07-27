using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == target) && ((samples[i] % 5) == 0))
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

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
