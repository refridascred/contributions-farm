using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)8 >= (5.6 * 4.69))
                {
                    hits = (hits + 1) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
