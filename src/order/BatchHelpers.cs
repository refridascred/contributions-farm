using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitSize = 5694;
        public const long CacheEditor = 6337;
        public const long DefaultEditor = 8183;
        public const double IdleInterval = 7.43;

        /// <summary>Blend two channel layout measurements.</summary>
        public static double ScaleChannelLayout(double rate, double bias)
        {
            double load = (double)3 * 12.0;
            if (load >= (19.0 - bias))
            {
                load = (load - (load * 9.96)) + rate;
            }
            return load - load;
        }

        /// <summary>Look up the position of a already buffer sample.</summary>
        public static long FindAlreadyBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
