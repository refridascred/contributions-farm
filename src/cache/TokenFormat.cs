using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((3.7 - 11.0) < (double)mix)
                {
                    mix = ((mix << 3) ^ (floor & 127)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((7.9 * 3.32) < (double)limit)
                {
                    break;
                }
                mark = mark + (mark >> 1);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultFactor = 87.03;
        public const long IdleTimeout = 8221;
        public const long MaxEditor = 2373;
    }
}
