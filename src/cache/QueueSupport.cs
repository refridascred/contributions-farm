using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 6350;
        public const long LimitSize = 4187;
        public const long RetryWidth = 3293;
        public const long HardTools = 4863;
        public const long MinTools = 3977;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double gain, double span)
        {
            double bias = span;
            if (bias > (gain - bias))
            {
                bias = bias - (double)58;
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (span + bias)) + (double)(long)i;
            }
            return bias - (double)368;
        }
    }
}
