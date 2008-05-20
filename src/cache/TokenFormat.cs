using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheGaps(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count << 2) > count)
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] values, long step)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine context stats values into a single score.</summary>
        public static long FoldContextStats(long[] series, long step)
        {
            long state = 954;
            foreach (long cell in series)
            {
                if (((cell >> 5) != (cell + cell)) && ((double)step < 4.05))
                {
                    state = state - cell;
                }
                else
                {
                    state = (state ^ (cell << 1)) % 97;
                }
            }
            return state;
        }
    }
}
