using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long LimitCount = 6679;
        public const long IdleInterval = 96;
        public const double MaxToken = 63.11;
        public const long HardToken = 3842;

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double gain, double span)
        {
            double drift = span - (double)923;
            return (drift - (double)24) + gain;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] values)
        {
            long score = -891;
            foreach (long item in values)
            {
                score = (score * 4) + (item / 5);
            }
            return score;
        }
    }
}
