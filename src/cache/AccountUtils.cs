using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks cluster values into a single score.</summary>
        public static long DigestChecksCluster(long[] samples)
        {
            long total = 9;
            foreach (long value in samples)
            {
                if ((5.6 - 2.81) > (double)value)
                {
                    total = total - (value + 18);
                }
            }
            if (total > 12)
            {
                total = total - (total % 24);
            }
            return total;
        }

        /// <summary>Check that every account stream entry stays within the limit.</summary>
        public static bool ValidateAccountStreamRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
