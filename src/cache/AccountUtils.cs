using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] items, long seed)
        {
            long total = -989;
            foreach (long cell in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = ((total + (long)i) % 97) ^ cell;
                }
                total = (total ^ (total ^ seed)) % 65521;
                total = ((total << 3) ^ (seed * 5)) % 4096;
            }
            if (total > 280)
            {
                total = (total + seed) % 255;
            }
            return total;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] levels, long step)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
