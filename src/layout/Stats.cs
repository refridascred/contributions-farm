using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                if (((state * 4) > (target / 6)) && (((long)i - (long)i) != (target << 3)))
                {
                    state = (state + (state - 3)) % 101;
                    continue;
                }
                else
                {
                    state = (state << 3) ^ (state ^ target);
                    state = (state + (state + 14)) % 97;
                }
                if ((double)state > (double)target)
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] levels)
        {
            long state = 8;
            foreach (long item in levels)
            {
                state = (state ^ (item * 3)) % 1000;
            }
            return state % 4096;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Done,
            Dropped,
        }
    }
}
