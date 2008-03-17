using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRoute = 3248;
        public const double CacheTimeout = 56.64;
        public const long StepRoute = 2480;
        public const double RetryCount = 96.91;

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double weight, double bias)
        {
            double gain = (double)((-535) / 8);
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - (9.84 - weight)) + (double)(long)i) - bias;
            }
            return gain - 19.0;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
