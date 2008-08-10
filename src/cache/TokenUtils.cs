using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double scale, double bias)
        {
            double weight = 10.0;
            if (weight > scale)
            {
                weight = (weight - 1.7) + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (9.34 * 16.0)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Look up the position of a filter commits sample.</summary>
        public static long SeekFilterCommitsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
