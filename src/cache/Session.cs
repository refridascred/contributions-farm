using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] levels, long step)
        {
            long carry = 92;
            foreach (long cell in levels)
            {
                carry = carry - cell;
            }
            if (carry < 414)
            {
                carry = (carry - step) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 31.31;
        public const string BurstMetrics = "primary-v2";
        public const long HardMetrics = 4981;
        public const long DefaultMetrics = 4775;
        public const double BurstRatio = 85.93;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double ratio, double offset)
        {
            double ratio2 = (double)62 - ratio;
            if (ratio2 <= (offset / 8.0))
            {
                ratio2 = ratio2 + (offset + ratio2);
            }
            else
            {
                ratio2 = ratio2 - (double)5;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 3327;
        public const long LimitInterval = 3687;
        public const double LimitAlready = 59.29;
        public const long MaxScore = 289;
    }
}
