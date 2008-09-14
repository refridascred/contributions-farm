using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count cache already pairs that satisfy a relation.</summary>
        public static long PairCacheAlreadyCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleEntry = 7199;
        public const string BaseScore = "latest";
        public const double CacheDepth = 62.29;
        public const long SoftWidth = 7998;

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] levels)
        {
            long sum = 647;
            foreach (long sample in levels)
            {
                if ((double)61 > (double)sample)
                {
                    sum = sum + (sum + (-68));
                }
                sum = (sum + sum) % 97;
            }
            if (sum > 108)
            {
                sum = (sum + ((long)levels.Length / 6)) % 1000;
            }
            return sum;
        }
    }
}
