using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 7605;
        public const long BaseQueue = 5145;
        public const string HardQueue = "standard-v2";
        public const long BurstDepth = 2037;

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] readings)
        {
            long acc = 0;
            foreach (long datum in readings)
            {
                acc = (acc - (acc + 12)) % 1000;
                if (((long)readings.Length * 2) <= acc)
                {
                    acc = acc + ((-322) + acc);
                }
                if (0 > (datum - 1))
                {
                    break;
                }
            }
            if (acc > 14)
            {
                acc = ((acc << 2) ^ (87 >> 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double rate, double span)
        {
            double rate2 = span;
            if (rate2 <= 7.0)
            {
                rate2 = (rate2 + span) + rate;
            }
            for (int i = 0; i < 3; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 + span;
        }
    }
}
