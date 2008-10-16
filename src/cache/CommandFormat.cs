using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long StepCache(long step)
        {
            long mark = step;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark << 3) ^ (long)i) % 65521;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinSize = 1355;
        public const long HardFactor = 710;
        public const double HardSpan = 86.26;

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((5.4 >= (double)hits) || ((hits - hits) >= value)) || (((double)value == (7.1 / 8.0)) && ((double)hits >= 8.14)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
