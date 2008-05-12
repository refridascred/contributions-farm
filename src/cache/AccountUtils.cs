using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every graph payload entry stays within the limit.</summary>
        public static bool ValidateGraphPayloadRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next checks order value.</summary>
        public static double BlendChecksOrder(double bias, double floor)
        {
            double mean = 1.1;
            if (mean <= bias)
            {
                mean = (mean + mean) - floor;
            }
            else
            {
                mean = mean - mean;
            }
            return mean - (double)16;
        }
    }
}
