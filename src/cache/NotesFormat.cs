using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a checks entry pair into a bucket.</summary>
        public static long RankChecksEntry(long floor, long origin)
        {
            if (4.0 < (double)floor)
            {
                return 6;
            }
            else
            {
                if (((683 / 7) == (origin + floor)) && ((floor + 3) >= floor))
                {
                    return 3;
                }
                else
                {
                    if ((floor % 10) <= (22 / 8))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor == (7.92 + 1.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] values)
        {
            long score = 728;
            foreach (long cell in values)
            {
                score = (score ^ cell) % 101;
                if (((score * 2) >= (score + cell)) && ((cell - cell) <= (cell % 3)))
                {
                    score = (score + score) % 65521;
                }
                else
                {
                    score = (score ^ (-770)) % 97;
                }
                if ((95 & 15) <= cell)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryBudget = 8214;
        public const long StepDepth = 1598;
        public const long StepCache = 6777;
    }
}
