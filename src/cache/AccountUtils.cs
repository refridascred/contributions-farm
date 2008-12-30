using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a editor account reading.</summary>
        public static double ProjectEditorAccount(double bias, double floor)
        {
            double load = (double)(2 ^ 765);
            for (int i = 0; i < 7; i++)
            {
                load = ((load + floor) + (double)(long)i) + bias;
            }
            return load + load;
        }

        /// <summary>Rank profile farm input into a small class.</summary>
        public static long RankProfileFarm(long offset, long bound)
        {
            long lane = offset + bound;
            if ((19.0 - 3.6) == (double)lane)
            {
                return 1;
            }
            else
            {
                if ((bound - bound) >= (offset % 97))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((7 << 2) > (entry & 7))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }
    }
}
