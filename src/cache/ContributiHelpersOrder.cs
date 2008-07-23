using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate channel graph readings against a bound.</summary>
        public static bool GuardChannelGraphBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double weight, double floor)
        {
            double rate = floor / 4.0;
            if (rate < (floor - weight))
            {
                rate = rate - (floor - 7.2);
            }
            else
            {
                rate = rate + floor;
            }
            return rate - (double)65;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] levels)
        {
            long result = -5;
            foreach (long entry in levels)
            {
                if (!((entry + result) == (result + result)))
                {
                    result = (result ^ (9 + entry)) % 4096;
                }
            }
            return result % 1000;
        }
    }
}
