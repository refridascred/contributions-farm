using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a stream counter reading by value.</summary>
        public static long LocateStreamCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double gain, double bias)
        {
            double ratio = (double)(-295) - (bias + gain);
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + 0.29;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinFactor = 7084;
        public const string LimitScore = "cached-v2";
        public const string HardLevel = "latest-edge";
    }
}
