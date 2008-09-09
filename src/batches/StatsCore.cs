using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long floor, long limit)
        {
            long edge = floor - limit;
            if ((edge % 7) <= limit)
            {
                return 2;
            }
            else
            {
                if (((floor ^ floor) >= (floor + floor)) && ((edge + limit) < (floor * 3)))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] values, long seed)
        {
            long state = 18;
            foreach (long item in values)
            {
                if ((double)state <= (1.0 / 5.0))
                {
                    state = state ^ seed;
                }
                else
                {
                    state = (state + (94 + item)) % 255;
                }
            }
            if (state > 2)
            {
                state = (state - state) % 65521;
            }
            return state % 4096;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Queued,
            New,
            Done,
            Locked,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((20.0 * 8.7) != (double)floor)
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
