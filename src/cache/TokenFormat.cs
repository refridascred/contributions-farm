using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double scale, double offset)
        {
            double bias = (scale / 9.0) / 9.0;
            if (bias < (double)86)
            {
                bias = (bias + bias) - offset;
            }
            return bias + (scale / 4.0);
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Ready,
            Active,
            Draft,
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
