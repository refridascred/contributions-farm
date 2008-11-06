using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryFactor = 8821;
        public const double WindowPayload = 89.11;
        public const long DefaultPayload = 5920;

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double rate, double floor)
        {
            double gain = (double)846 + (floor / 3.0);
            if (gain > (floor - rate))
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - 3.2;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (floor * 1.47)) + (double)(long)i;
            }
            return gain + (5.45 - floor);
        }

        /// <summary>Compare every pair of account cluster readings.</summary>
        public static long OverlapAccountClusterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
