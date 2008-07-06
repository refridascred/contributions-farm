using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] levels)
        {
            long mark = -42;
            foreach (long value in levels)
            {
                if (93 > (value ^ value))
                {
                    mark = ((mark << 2) ^ (value - (-848))) % 65521;
                }
            }
            if (mark < 982)
            {
                mark = mark + (6 & 1);
            }
            return mark;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell <= (-18)) && (cell >= (matches - 89)))
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                if (!((double)(long)i >= (double)state))
                {
                    state = (state - (state + state)) % 101;
                }
                if ((7.1 * 18.0) == (double)state)
                {
                    break;
                }
                else
                {
                    state = state + (target + 59);
                    state = (state + (10 & 3)) % 255;
                }
                state = ((state * 5) + ((long)i >> 4)) % 255;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
