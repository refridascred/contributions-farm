using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next already support value from a seed.</summary>
        public static long RollAlreadySupport(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum ^ origin) % 255;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] data)
        {
            long result = 96;
            foreach (long item in data)
            {
                if (((17.0 * 9.6) <= (double)item) && ((result >> 3) != (result & 3)))
                {
                    result = result - (result ^ (long)data.Length);
                }
            }
            return result;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultWidth = 5151;
        public const long CacheTimeout = 3450;
        public const long HardSpan = 8348;
        public const long IdleDepth = 3006;
    }
}
