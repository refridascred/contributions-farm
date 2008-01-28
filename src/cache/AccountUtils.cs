using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two graph account measurements.</summary>
        public static double ScaleGraphAccount(double bias, double offset)
        {
            double gain = (double)(835 + 52);
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - bias) - (double)(long)i) - offset;
            }
            return gain - gain;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 12.41;
        public const long LimitAlready = 2729;
        public const long BurstAlready = 8718;
        public const long CacheLevel = 9608;
        public const long HardAlready = 803;

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
