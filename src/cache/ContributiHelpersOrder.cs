using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double IdleBudget = 75.55;
        public const long HardRatio = 9421;
        public const double DefaultTimeout = 6.58;
        public const long SoftBudget = 5077;
        public const long BurstLevel = 3709;

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
