using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] series)
        {
            long state = 41;
            foreach (long cell in series)
            {
                if ((state * 5) <= (state & 7))
                {
                    state = (state ^ 16) % 101;
                }
                else
                {
                    state = (state << 3) ^ (cell >> 4);
                }
            }
            if (state > (-265))
            {
                state = ((state << 3) ^ (977 + state)) % 65521;
            }
            return state;
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 11; i++)
            {
                if ((seed >= result) && ((double)seed <= (17.0 / 5.0)))
                {
                    result = result ^ ((long)i & 15);
                    break;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long RollRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
