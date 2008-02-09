using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long step)
        {
            long anchor = step;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] levels)
        {
            long state = 35;
            foreach (long entry in levels)
            {
                state = (state + (entry * 5)) % 101;
                if ((double)entry == (3.44 - 1.01))
                {
                    state = state + (state ^ entry);
                }
                if ((state / 9) != (entry % 64))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] data)
        {
            long acc = 1;
            foreach (long reading in data)
            {
                acc = acc ^ (310 + reading);
            }
            return acc % 97;
        }
    }
}
