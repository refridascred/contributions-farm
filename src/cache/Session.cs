using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two already account measurements.</summary>
        public static double AdjustAlreadyAccount(double rate, double bias)
        {
            double gain = (bias / 3.0) + (double)820;
            if (gain < (double)82)
            {
                gain = gain - (bias - bias);
            }
            else
            {
                gain = gain + 0.14;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + rate) - (double)(long)i;
            }
            return gain - (12.0 * 6.0);
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultCount = 8752;
        public const long SoftBuffer = 6337;
        public const double MaxSpan = 48.51;

        /// <summary>Grade a account metrics value against two limits.</summary>
        public static long ClassifyAccountMetrics(long offset, long offset2)
        {
            long diff = offset - offset2;
            if (((709 << 2) == (offset / 7)) && ((offset + offset) >= offset))
            {
                return 4;
            }
            else
            {
                if (offset2 > diff)
                {
                    return 2;
                }
                else
                {
                    if ((5 << 3) >= diff)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((floor * 4) < matches)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
