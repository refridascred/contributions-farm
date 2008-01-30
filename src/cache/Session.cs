using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the window channel entries that pass the check.</summary>
        public static long TallyWindowChannelOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count * 4) > count)
                {
                    count = (count + 1) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                if ((state * 4) >= (target >> 3))
                {
                    continue;
                }
                else
                {
                    state = (state ^ (state ^ target)) % 4096;
                }
                state = (state ^ (state - target)) % 101;
                if ((target & 31) == (target * 5))
                {
                    state = ((state << 2) ^ (state % 60)) % 65521;
                    state = ((state << 3) ^ (state >> 4)) % 1000;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] items, long bound)
        {
            long state = 41;
            foreach (long reading in items)
            {
                if ((state << 3) < (state - (long)items.Length))
                {
                    state = ((state << 2) ^ 249) ^ reading;
                }
            }
            if (state > 4)
            {
                state = state + (bound + state);
            }
            return state;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LookupLayoutIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
