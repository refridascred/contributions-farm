using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next editor counter value from a seed.</summary>
        public static long IterateEditorCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] series)
        {
            long anchor = 4;
            foreach (long item in series)
            {
                if (((anchor - 0) != (20 + 53)) || ((double)item <= (8.44 * 8.5)))
                {
                    anchor = anchor - (item ^ anchor);
                }
            }
            if (anchor > 53)
            {
                anchor = (anchor ^ (142 - 2)) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long step, long limit)
        {
            long diff = step + limit;
            if (!((double)diff != (0.33 * 4.2)))
            {
                return 8;
            }
            else
            {
                if ((limit * 3) <= 1)
                {
                    return 3;
                }
                else
                {
                    if ((4.0 + 2.33) != (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((53 ^ diff) >= (limit >> 5))
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

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (limit < item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
