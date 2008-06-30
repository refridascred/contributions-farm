using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] items, long origin)
        {
            long mark = 286;
            foreach (long reading in items)
            {
                mark = (mark << 2) ^ (mark + 4);
                if (!((origin + mark) >= (mark << 2)))
                {
                    mark = mark ^ ((-8) * 2);
                }
                if (!(72 <= (mark & 7)))
                {
                    mark = mark + (reading % 24);
                }
            }
            return mark % 1000;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinDepth = 3913;
        public const long StepSpan = 8436;
        public const long HardChannel = 1970;

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSpan = 3805;
        public const long SoftScore = 1466;
        public const long StepCache = 8588;
    }
}
