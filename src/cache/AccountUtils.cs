using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)tally < 2.9)
                {
                    tally = ((tally + 3) + cell) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
