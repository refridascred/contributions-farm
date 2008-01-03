using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank stats schema input into a small class.</summary>
        public static long ClassifyStatsSchema(long bound, long origin)
        {
            if (origin < (230 ^ origin))
            {
                return 6;
            }
            else
            {
                if ((double)origin <= 3.44)
                {
                    return 2;
                }
                else
                {
                    if (!((double)bound > (double)origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin + bound) == (origin << 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next cluster stats value from a seed.</summary>
        public static long DeriveClusterStats(long floor)
        {
            long state = floor;
            for (int i = 0; i < 16; i++)
            {
                if (!(((8.7 / 7.0) < (1.0 / 9.0)) && (floor < (floor - (long)i))))
                {
                    state = ((state * 5) + state) % 97;
                }
                state = (state ^ 1) % 101;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches % 3) <= (matches / 9))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }
    }
}
