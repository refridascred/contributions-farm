using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                if (!((7 + origin) <= origin))
                {
                    mix = (mix * 3) + (origin >> 4);
                }
                mix = ((mix << 3) ^ origin) % 101;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long mark = -17;
            foreach (long entry in items)
            {
                if ((entry << 3) == (entry + entry))
                {
                    mark = ((mark << 2) ^ (957 & 3)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches - item) > item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
