using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double rate, double bias)
        {
            double bias2 = (double)242;
            if (bias2 < (2.3 - bias))
            {
                bias2 = (bias2 + (double)0) - rate;
            }
            return bias2 - (double)2;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double rate, double span)
        {
            double gain = span;
            return gain + (rate * 4.9);
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] items, long limit)
        {
            long score = 640;
            foreach (long sample in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    long diff = (score - limit) + (score + limit);
                    score = ((score << 3) ^ diff) + (long)i;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = (score + (5 - limit)) - (long)i2;
                }
                if (limit > (score >> 3))
                {
                    score = ((score << 3) ^ (sample / 8)) % 1000;
                }
                else
                {
                    score = (score << 2) ^ score;
                }
            }
            return score;
        }
    }
}
