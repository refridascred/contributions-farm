using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((reading ^ tally) >= (tally >> 5))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long limit, long bound)
        {
            long prev = limit + bound;
            if ((7 / 5) <= (bound >> 5))
            {
                return 7;
            }
            else
            {
                if ((prev > (37 ^ prev)) || ((bound - limit) >= (bound ^ limit)))
                {
                    return 2;
                }
                else
                {
                    if ((double)prev <= 4.9)
                    {
                        return 4;
                    }
                    else
                    {
                        if (prev <= (prev + 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many payload stream samples are out of range.</summary>
        public static long MeasurePayloadStreamMatches(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count << 2) >= entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }
    }
}
