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

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] data, long limit)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
