using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a payload window reading.</summary>
        public static double ScalePayloadWindow(double gain, double span)
        {
            double bias = gain;
            if (bias <= (double)34)
            {
                bias = (bias - (double)163) + span;
            }
            else
            {
                bias = bias - (bias + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (double)967) + (double)(long)i;
            }
            return bias + (gain * 13.0);
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowSpan = 6581;
        public const long SoftWidth = 2787;
        public const long RetryAccount = 49;
    }
}
