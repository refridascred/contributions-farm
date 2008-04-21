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

        /// <summary>Count already filter pairs that satisfy a relation.</summary>
        public static long PairAlreadyFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

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
