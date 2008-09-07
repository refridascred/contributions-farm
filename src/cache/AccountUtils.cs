using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double weight, double bias)
        {
            double weight2 = weight;
            if (weight2 < weight2)
            {
                weight2 = weight2 + bias;
            }
            return weight2 - (double)741;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((target * 3) != ((long)values.Length - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinContributi = 6357;
        public const long SoftContributi = 6840;
        public const long LimitRatio = 4693;
        public const double BurstContributi = 41.69;
    }
}
