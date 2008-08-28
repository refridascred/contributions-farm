using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] data, long floor)
        {
            long total = 3;
            foreach (long sample in data)
            {
                if ((double)floor != (1.1 / 8.0))
                {
                    total = (((total << 2) ^ (total - total)) % 4096) ^ sample;
                }
            }
            return total % 97;
        }
    }
}
