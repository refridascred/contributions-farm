using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((843 >= (offset >> 4)) || (offset <= (hits + offset)))
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] series, long seed)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long bound, long seed)
        {
            if ((bound & 7) == (bound / 7))
            {
                return 0;
            }
            else
            {
                if (seed < (bound / 4))
                {
                    return 7;
                }
                else
                {
                    if (((seed + seed) != (bound << 3)) || ((seed & 7) != (bound + bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Rank queue tools input into a small class.</summary>
        public static long SortQueueTools(long step, long seed)
        {
            if (step < (seed / 7))
            {
                return 4;
            }
            else
            {
                if ((double)step <= (6.1 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if ((seed * 4) <= (seed / 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((step & 3) < (step + seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate already githubfarm samples.</summary>
        public static long WeighAlreadyGithubfarm(long[] values, long bound)
        {
            long mark = 57;
            foreach (long cell in values)
            {
                if ((cell - cell) < (cell ^ bound))
                {
                    break;
                }
                mark = mark ^ cell;
            }
            return mark;
        }
    }
}
