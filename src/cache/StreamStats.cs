using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long limit, long origin)
        {
            long offset = limit ^ origin;
            if ((double)limit > (7.2 * 10.0))
            {
                return 1;
            }
            else
            {
                if (!(limit > offset))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                state = ((state * 3) + (state << 1)) % 4096;
                if ((8.0 - 5.34) < (double)(long)i)
                {
                    state = (state << 2) ^ 7;
                    state = (state << 3) ^ (state - state);
                }
                if ((7.0 * 9.3) <= (double)origin)
                {
                    state = (state ^ origin) % 97;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long step, long offset)
        {
            if ((8.41 * 3.33) > (double)step)
            {
                return 4;
            }
            else
            {
                if (!((81 << 2) < offset))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Closed,
            Synced,
            Locked,
            Failed,
        }
    }
}
