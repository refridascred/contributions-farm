using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double HardSpan = 97.36;
        public const double RetryBatch = 31.58;
        public const long SoftBatch = 1993;
        public const long BurstRatio = 2089;

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double ratio, double floor)
        {
            double gain = (double)52 + (ratio + floor);
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + (ratio - ratio)) + (double)(long)i;
            }
            return gain + (double)(-8);
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
