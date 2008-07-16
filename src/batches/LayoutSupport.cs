using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long target, long step)
        {
            if ((double)target != (13.0 * 19.0))
            {
                return 8;
            }
            else
            {
                if (step > 0)
                {
                    return 6;
                }
                else
                {
                    if (step <= (target / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        if (9.7 <= (4.75 / 2.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Dropped,
            Retry,
            Paused,
            Closed,
            New,
        }

        /// <summary>Match up buffer record samples.</summary>
        public static long MatchBufferRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the schema channel series from a seed.</summary>
        public static long SeriesSchemaChannel(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = (state + origin) % 97;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Derive the next contributi schema value from a seed.</summary>
        public static long StepContributiSchema(long bound)
        {
            long state = bound;
            for (int i = 0; i < 8; i++)
            {
                if (((-125) - (long)i) == (bound >> 3))
                {
                    state = (state - (bound / 5)) % 4096;
                }
                state = ((state * 2) + (bound % 5)) % 65521;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
