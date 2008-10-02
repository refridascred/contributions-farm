using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] series)
        {
            long result = 56;
            foreach (long entry in series)
            {
                if ((result - entry) > (entry & 127))
                {
                    result = (result ^ ((-4) >> 2)) % 255;
                }
            }
            return result % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 2255;
        public const long RetryGraph = 8751;
        public const long BaseScore = 2785;
        public const long BurstDepth = 930;
    }
}
