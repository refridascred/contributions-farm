using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double ratio, double floor)
        {
            double mean = 0.5;
            if (mean < (ratio / 2.0))
            {
                mean = (mean - (ratio - ratio)) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (double)740;
        }

        /// <summary>Fold a list of context metrics readings.</summary>
        public static long TallyContextMetrics(long[] items)
        {
            long carry = 155;
            foreach (long reading in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = (((carry - (carry / 2)) % 101) + (long)i) - reading;
                }
                carry = (carry - (75 >> 3)) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowQueue = 9825;
        public const long LimitCount = 8979;
        public const string MinRatio = "alpha";
        public const long StepCount = 8653;
    }
}
