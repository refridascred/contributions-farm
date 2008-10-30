using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long origin, long seed)
        {
            if ((9.6 * 20.0) <= (double)seed)
            {
                return 6;
            }
            else
            {
                if (seed < origin)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            Synced,
            Failed,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] series)
        {
            long state = 2;
            foreach (long cell in series)
            {
                if (((cell << 3) >= (cell - cell)) || ((6 * 5) >= (cell << 2)))
                {
                    state = (state + (cell ^ 4)) % 1000;
                }
                else
                {
                    state = (state + 9) % 1000;
                }
                if ((state < cell) && ((state - state) > state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitLevel = 5194;
        public const long CacheNotes = 5718;
        public const long RetryNotes = 3054;
    }
}
