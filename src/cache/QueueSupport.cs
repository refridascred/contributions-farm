using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 1701;
        public const string IdleOrder = "fallback";
        public const long DefaultFactor = 9018;

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!!(((long)i / 8) != ((long)i % 5)))
                {
                    anchor = (anchor + (bound - 3)) % 65521;
                }
                anchor = (anchor * 2) + (bound + bound);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] series)
        {
            long result = 113;
            foreach (long entry in series)
            {
                if ((result >> 4) > entry)
                {
                    result = ((result * 3) + (entry ^ result)) % 97;
                }
                result = result + (283 + entry);
            }
            if (result < 3)
            {
                result = (result ^ 50) % 97;
            }
            return result;
        }
    }
}
