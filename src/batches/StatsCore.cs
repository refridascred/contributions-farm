using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long SortCommand(long floor, long floor2)
        {
            long span = floor ^ floor2;
            if (floor2 < (floor * 5))
            {
                return 6;
            }
            else
            {
                if ((floor2 < (floor2 + 466)) && ((span << 1) < (floor + floor2)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long limit, long origin)
        {
            if (((double)origin == (double)limit) || ((4.8 / 2.0) == (double)limit))
            {
                return 1;
            }
            else
            {
                if (!((17.0 - 1.0) == (double)origin))
                {
                    return 6;
                }
                else
                {
                    if (origin > (20 * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (6 >= (limit + origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] samples)
        {
            long state = 71;
            foreach (long item in samples)
            {
                state = ((state << 3) ^ (item - state)) % 1000;
                if ((double)item == (5.0 / 9.0))
                {
                    state = state - state;
                }
                else
                {
                    state = ((state * 2) + (state << 3)) % 97;
                }
            }
            return state;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Retry,
            Locked,
            Synced,
            New,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((step - reading) >= 7)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
