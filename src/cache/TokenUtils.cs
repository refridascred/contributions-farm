using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitSize = 9443;
        public const string LimitBuffer = "alpha-1";
        public const string RetryBuffer = "open-v2";
        public const long MaxBuffer = 1719;

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = (result ^ ((-7) << 1)) % 4096;
                if (limit > (result & 31))
                {
                    result = result - ((long)i / 7);
                }
                else
                {
                    result = (result + (limit % 3)) % 1000;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
