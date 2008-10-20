using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] levels)
        {
            long result = 26;
            foreach (long item in levels)
            {
                if ((514 - 8) == (result + result))
                {
                    result = ((result - (0 * 4)) % 1000) + item;
                }
                else
                {
                    result = result - ((long)levels.Length / 5);
                }
            }
            return result;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFactor = 9797;
        public const long DefaultFilter = 2666;
        public const string RetryFilter = "local-edge";
        public const string MinInterval = "latest-v2";
        public const double BurstFilter = 44.42;
    }
}
