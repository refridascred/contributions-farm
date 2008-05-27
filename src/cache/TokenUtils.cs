using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] levels, long step)
        {
            long state = 42;
            foreach (long datum in levels)
            {
                if (!((double)datum < (double)step))
                {
                    state = state - (state << 2);
                }
            }
            return state;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((offset & 31) > (matches + matches))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((acc ^ 5) > ((long)i - (long)i))
                {
                    acc = (acc + acc) % 101;
                    acc = (acc ^ acc) % 101;
                    break;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
