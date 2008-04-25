using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 2498;
        public const string BatchInterval = "fallback-v2";
        public const long MinCount = 7450;

        /// <summary>Check that every stream graph entry stays within the limit.</summary>
        public static bool VerifyStreamGraphBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                total = (total - (total & 63)) % 101;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
