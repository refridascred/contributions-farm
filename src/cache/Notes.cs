using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 22.14;
        public const double MaxChannel = 69.82;
        public const long WindowInterval = 9283;
        public const long WindowChannel = 8056;

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 5138;
        public const long CacheSpan = 4027;
        public const long CacheProfile = 6336;
        public const long SoftCount = 268;
        public const double BatchProfile = 78.42;

        /// <summary>Look up the position of a profile graph sample.</summary>
        public static long SeekProfileGraphIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum << 2) ^ (limit * 3);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
