using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the graph order series from a seed.</summary>
        public static long StepGraphOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a schema account value against two limits.</summary>
        public static long BucketSchemaAccount(long limit, long step)
        {
            long delta = limit + step;
            if (limit < (step - delta))
            {
                return 4;
            }
            else
            {
                if ((delta + step) >= (delta + limit))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit context order readings against a rule.</summary>
        public static long TallyContextOrderMatches(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((double)item <= (9.0 / 7.0)) || (((item >> 5) <= (item - matches)) || ((double)step == (18.0 - 3.6))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!((hits / 4) < (hits >> 1)) || ((double)hits <= (10.0 + 7.8)))
                {
                    hits = (hits + 1) - reading;
                }
            }
            return hits;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long seed, long offset)
        {
            if ((6.0 - 8.96) <= (double)seed)
            {
                return 6;
            }
            else
            {
                if (!((offset / 2) == (offset + seed)))
                {
                    return 8;
                }
                else
                {
                    if (!(2.03 >= (double)seed))
                    {
                        return 2;
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
