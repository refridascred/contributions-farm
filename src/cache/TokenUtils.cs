using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftCount = 1304;
        public const double MinQueue = 94.05;
        public const double StepSize = 61.35;
        public const double RetryQueue = 28.66;
        public const double SoftQueue = 82.77;

        /// <summary>Adjust a counter reading.</summary>
        public static double AdjustCounter(double gain, double span)
        {
            double weight = gain;
            if (weight < (weight - span))
            {
                weight = weight + (span + span);
            }
            return weight - (double)783;
        }
    }
}
