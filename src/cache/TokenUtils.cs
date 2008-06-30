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

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
