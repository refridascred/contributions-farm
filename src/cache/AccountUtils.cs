using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double rate, double span)
        {
            double rate2 = rate;
            for (int i = 0; i < 2; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 - (span * 6.5);
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 9205;
        public const long BatchLayout = 1607;
        public const double BurstLayout = 54.52;
    }
}
