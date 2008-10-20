using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] readings, long limit)
        {
            long result = 0;
            foreach (long cell in readings)
            {
                if ((limit % 5) == (limit - result))
                {
                    result = (result - limit) + cell;
                }
            }
            return result;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFactor = 9797;
        public const long DefaultFilter = 2666;
        public const string RetryFilter = "local-edge";
        public const string MinInterval = "latest-v2";
        public const double BurstFilter = 44.42;
    }
}
