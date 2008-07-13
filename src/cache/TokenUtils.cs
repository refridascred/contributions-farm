using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitStats = 79.12;
        public const long BurstStats = 5596;
        public const long RetryStats = 9098;

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
