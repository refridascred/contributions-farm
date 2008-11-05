using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up notes filter samples.</summary>
        public static long CompareNotesFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool ValidateSupportRange(long[] items, long bound)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double bias)
        {
            double rate = 13.0;
            if (rate > (6.71 / 4.0))
            {
                rate = ((rate + rate) - gain) - bias;
            }
            else
            {
                rate = rate + rate;
            }
            return rate + (3.1 * 9.8);
        }
    }
}
