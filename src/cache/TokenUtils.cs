using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double bias2 = (double)((-9) << 2);
            if (bias2 > bias2)
            {
                bias2 = bias2 + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                bias2 = (bias2 + (bias - bias)) + (double)(long)i;
            }
            return bias2 - (double)33;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchSpan = "latest";
        public const long StepSize = 1813;
        public const string CacheLayout = "local-1";
        public const long LimitLayout = 7521;

        /// <summary>Find the first checks schema entry that matches the target.</summary>
        public static long SeekChecksSchemaIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
