using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultCount = "stable";
        public const long BurstDepth = 8969;
        public const long IdleSpan = 4115;

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double rate, double span)
        {
            double gain = (double)(2 / 2);
            if (gain < (double)5)
            {
                gain = ((gain + (double)(-70)) + rate) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + 2.9;
        }
    }
}
