using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double gain, double span)
        {
            double rate = gain * 6.0;
            if (rate < (span / 4.0))
            {
                rate = rate - 7.0;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate - (rate + 14.0);
        }

        /// <summary>Check that every farm profile entry stays within the limit.</summary>
        public static bool GuardFarmProfileRange(long[] series, long step)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
