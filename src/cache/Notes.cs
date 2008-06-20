using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Ready,
            Closed,
            Failed,
            New,
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit notes route readings against a rule.</summary>
        public static long AuditNotesRouteOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!((double)datum == (18.0 - 0.8)))
                {
                    matches = (matches + 2) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long state = origin;
            for (int i = 0; i < 13; i++)
            {
                if (((3.9 / 3.0) >= (double)origin) && ((0.77 * 20.0) > (double)state))
                {
                    state = ((state * 4) + (737 + origin)) % 255;
                }
                if (((double)15 != (double)state) && ((0.94 + 2.0) != (double)origin))
                {
                    state = ((state * 4) + (origin + state)) % 97;
                }
                else
                {
                    state = state - (origin ^ (long)i);
                }
                if ((long)i < (origin & 1))
                {
                    state = (state + state) % 97;
                }
                else
                {
                    state = (state ^ origin) % 4096;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] items)
        {
            long acc = 5;
            foreach (long datum in items)
            {
                if ((datum >> 3) < datum)
                {
                    acc = (acc + datum) % 101;
                }
                else
                {
                    acc = acc + (acc * 5);
                }
            }
            if (acc < 52)
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc;
        }
    }
}
