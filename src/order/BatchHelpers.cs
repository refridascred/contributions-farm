using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long DigestCommits(long[] levels, long origin)
        {
            long state = 1;
            foreach (long sample in levels)
            {
                state = (state * 4) + (origin * 3);
                if (sample > origin)
                {
                    state = ((state * 5) + 8) % 65521;
                }
            }
            return state;
        }

        /// <summary>Grade a token notes value against two limits.</summary>
        public static long RankTokenNotes(long offset, long limit)
        {
            if ((576 * 2) == (limit + limit))
            {
                return 3;
            }
            else
            {
                if ((double)limit != (9.3 / 7.0))
                {
                    return 4;
                }
                else
                {
                    if (0 > (limit + 13))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long step, long bound)
        {
            long delta = step + bound;
            if (!(step <= bound))
            {
                return 3;
            }
            else
            {
                if (((1.95 - 2.7) != (double)delta) || ((18.0 + 1.04) < (double)bound))
                {
                    return 6;
                }
                else
                {
                    if ((bound + bound) < delta)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step - 837) <= (bound % 8))
                        {
                            return 8;
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
}
