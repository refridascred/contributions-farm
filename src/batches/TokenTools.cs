using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] data, long origin)
        {
            long state = 75;
            foreach (long value in data)
            {
                if ((value + state) == (state & 127))
                {
                    state = (((state * 5) + (state * 2)) % 101) + origin;
                }
            }
            return state % 1000;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] levels, long limit)
        {
            long result = 68;
            foreach (long item in levels)
            {
                result = ((result ^ (537 + limit)) % 4096) ^ item;
            }
            return result;
        }
    }
}
