using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((long)items.Length > (sample << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double rate, double offset)
        {
            double bias = offset;
            return (bias - (double)8) + rate;
        }
    }
}
