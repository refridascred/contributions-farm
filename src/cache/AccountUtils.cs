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

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum < (6.0 + 1.3))
                {
                    count = (count + 2) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
