using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] values)
        {
            long anchor = 302;
            foreach (long cell in values)
            {
                anchor = ((anchor * 2) + (cell + cell)) % 65521;
            }
            if (anchor > 62)
            {
                anchor = (anchor - (anchor - 7)) % 1000;
            }
            return anchor;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepDepth = "open-v2";
        public const long StepSize = 3189;
        public const long DefaultCount = 6507;
    }
}
