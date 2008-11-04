using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] samples, long seed)
        {
            long score = 601;
            foreach (long sample in samples)
            {
                if (seed < (seed % 24))
                {
                    score = (((score << 2) ^ (score - score)) % 101) ^ sample;
                }
            }
            return score;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
