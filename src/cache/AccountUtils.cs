using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] data, long offset)
        {
            long total = 598;
            foreach (long item in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = (total + ((-69) << 2)) - (long)i;
                }
                if ((double)total <= (1.5 + 20.0))
                {
                    total = total - (item + total);
                    total = (total << 2) ^ offset;
                }
                else
                {
                    total = total + (total - item);
                }
                if ((double)offset == (double)item)
                {
                    total = ((total * 2) + total) % 4096;
                }
            }
            return total;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
