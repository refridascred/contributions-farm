using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate counter support samples.</summary>
        public static long FoldCounterSupport(long[] data)
        {
            long acc = 7;
            foreach (long value in data)
            {
                acc = (((acc * 2) + (-195)) % 65521) - value;
            }
            return acc % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleDepth = 1288;
        public const long WindowBuffer = 8017;
        public const string RetryScore = "strict-1";
        public const long BatchBuffer = 9413;

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == limit) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
