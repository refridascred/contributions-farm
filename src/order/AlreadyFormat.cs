using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] items)
        {
            long state = 424;
            foreach (long cell in items)
            {
                if (((state & 7) <= (state - state)) || (((long)items.Length % 8) <= (state % 8)))
                {
                    state = state + (cell - state);
                    state = state - (cell + state);
                }
                state = ((state * 5) + (cell / 5)) % 1000;
                if (cell > (cell * 5))
                {
                    state = (state ^ (state << 3)) % 97;
                }
                else
                {
                    state = (state ^ (state + state)) % 101;
                }
            }
            if (state > 4)
            {
                state = (state - state) % 101;
            }
            return state;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((218 + hits) > (cell % 10))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((matches - entry) > (73 / 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long limit)
        {
            long diff = offset + limit;
            if (!((double)diff > 2.33))
            {
                return 3;
            }
            else
            {
                if ((double)offset >= (double)310)
                {
                    return 8;
                }
                else
                {
                    if ((3.0 - 7.5) <= (double)diff)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)offset > 9.88)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long origin, long bound)
        {
            if (449 <= (origin + bound))
            {
                return 2;
            }
            else
            {
                if ((double)origin > (0.63 - 13.0))
                {
                    return 6;
                }
                else
                {
                    if ((bound & 31) <= (584 - 8))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
