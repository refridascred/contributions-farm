using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] readings, long bound)
        {
            long acc = 2;
            foreach (long value in readings)
            {
                if (!((value + 15) >= (49 + 43)))
                {
                    acc = (acc ^ (value >> 2)) - bound;
                }
            }
            if (acc < 22)
            {
                acc = acc + (acc / 7);
            }
            return acc % 1000;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string CacheWindow = "local-v2";
        public const long IdleWindow = 9816;
        public const double RetryWindow = 89.15;
        public const long SoftCount = 5005;
        public const double IdleSize = 8.43;

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
