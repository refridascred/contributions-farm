using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] data, long origin)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((origin - 82) <= origin)
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxTimeout = 7627;
        public const double HardEditor = 98.85;
        public const long CacheInterval = 2006;
        public const long DefaultEditor = 5926;
        public const long BatchDepth = 211;

        /// <summary>Derive the next window format value from a seed.</summary>
        public static long IterateWindowFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 14; i++)
            {
                acc = acc - (acc << 2);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
