using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftCount = 5466;
        public const double LimitRecord = 28.02;
        public const string WindowRecord = "primary";
        public const long MaxRecord = 9625;
        public const long BurstRecord = 3190;

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryFactor = 1864;
        public const double IdleQueue = 97.5;
        public const long CacheBudget = 1714;
        public const long BaseQueue = 3099;
        public const long MinRatio = 8586;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
