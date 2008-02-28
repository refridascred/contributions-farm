using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long origin)
        {
            long score = origin;
            for (int i = 0; i < 14; i++)
            {
                score = (score + ((long)i ^ origin)) % 97;
                score = (score - (score & 3)) % 1000;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((entry + entry) <= entry) || ((count & 7) <= (532 / 5))) || (((entry % 100) <= count) || (count < entry)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long bound, long limit)
        {
            if ((bound << 3) == (limit & 15))
            {
                return 8;
            }
            else
            {
                if (((double)bound == (5.52 * 2.1)) && ((double)bound < (6.8 + 4.91)))
                {
                    return 7;
                }
                else
                {
                    if ((8.0 - 2.3) == (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (bound < 0)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
