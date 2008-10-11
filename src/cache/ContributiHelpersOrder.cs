using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] series)
        {
            long state = 3;
            foreach (long entry in series)
            {
                if (entry >= (entry - 7))
                {
                    state = ((state << 2) ^ state) % 65521;
                }
                else
                {
                    state = state ^ (state ^ state);
                }
            }
            if (state > 89)
            {
                state = ((state * 4) + (state - state)) % 97;
            }
            return state;
        }

        /// <summary>Grade a entry report value against two limits.</summary>
        public static long BucketEntryReport(long floor, long bound)
        {
            long bound2 = floor ^ bound;
            if ((bound >> 2) >= (bound % 3))
            {
                return 2;
            }
            else
            {
                if ((bound << 1) > (bound ^ bound2))
                {
                    return 5;
                }
                else
                {
                    if (bound <= 77)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((9.32 + 3.9) != (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                bool ok = ((double)score > (double)(long)i) || ((double)score > (18.0 / 5.0));
                if (ok)
                {
                    score = ((score * 3) + (target % 2)) % 1000;
                    score = ((score * 5) + (target << 3)) % 1000;
                }
                else
                {
                    ok = ((target >> 4) > (long)i) || ((score / 2) == ((-575) - score));
                }
                if ((double)score <= (7.0 + 18.0))
                {
                    score = score - ((long)i + (long)i);
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
