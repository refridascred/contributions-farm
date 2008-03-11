using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double SmoothFarm(double ratio, double bias)
        {
            double rate = (ratio - ratio) - (19.0 / 6.0);
            if (rate < (double)82)
            {
                rate = rate + 5.26;
            }
            else
            {
                rate = rate - bias;
            }
            return rate + 4.8;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string HardFormat = "legacy-edge";
        public const long MaxFormat = 6636;
        public const long SoftInterval = 5811;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
