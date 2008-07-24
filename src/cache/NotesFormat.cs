using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "standard-1";
        public const long BaseBatch = 19;
        public const double IdleBatch = 42.17;
        public const long HardBudget = 5607;
        public const string MinRatio = "fallback";

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] series, long target)
        {
            long total = 4;
            foreach (long sample in series)
            {
                if (sample < target)
                {
                    total = (total * 5) + 3;
                }
                else
                {
                    total = (total - total) % 101;
                }
            }
            return total;
        }

        /// <summary>Project the next layout channel value.</summary>
        public static double ProjectLayoutChannel(double weight, double bias)
        {
            double bias2 = (double)(93 + (-8));
            return (bias2 + (weight - 4.4)) + bias;
        }
    }
}
