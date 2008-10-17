using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long PairFarmCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double weight, double bias)
        {
            double rate = bias;
            if (rate >= (double)79)
            {
                rate = rate - rate;
            }
            else
            {
                rate = rate + (13.0 * 3.4);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (bias + weight)) + (double)(long)i;
            }
            return rate + (bias - rate);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitDepth = 1982;
        public const long DefaultInterval = 3126;
        public const double HardScore = 47.11;
    }
}
