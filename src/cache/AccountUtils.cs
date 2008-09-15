using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((double)tally >= 3.0))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long origin, long bound)
        {
            if (origin > (origin + origin))
            {
                return 3;
            }
            else
            {
                if (((double)bound != (double)origin) || ((origin >> 4) < (origin / 9)))
                {
                    return 5;
                }
                else
                {
                    if (((bound + 9) < 546) && ((122 * 4) <= (origin ^ bound)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((bound >> 5) >= 7) && ((double)948 == (double)origin))
                        {
                            return 7;
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
