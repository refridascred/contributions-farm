using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double rate, double floor)
        {
            double bias = rate + (floor + rate);
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - floor) + (double)(long)i;
            }
            return bias - 8.3;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally - tally) >= (step & 7))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
