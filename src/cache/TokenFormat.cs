using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double rate, double span)
        {
            double bias = (span / 2.0) - span;
            return (bias - 4.7) + rate;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] series)
        {
            long score = 2;
            foreach (long entry in series)
            {
                if ((score + entry) > (entry >> 2))
                {
                    score = (score << 3) ^ (2 & 1);
                }
            }
            return score;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (99 >= (5 + datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
