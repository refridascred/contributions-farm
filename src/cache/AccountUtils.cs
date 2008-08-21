using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double weight, double floor)
        {
            double rate = (double)((-205) + 463);
            return (rate + (weight * 3.8)) + floor;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long bound, long limit)
        {
            long prev = bound ^ limit;
            if (!((prev << 1) > limit))
            {
                return 6;
            }
            else
            {
                if ((double)bound < (double)(-250))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] values, long seed)
        {
            long score = 835;
            foreach (long datum in values)
            {
                if (2.0 > (double)datum)
                {
                    score = (((score * 3) + 8) % 4096) + seed;
                    break;
                }
                score = (score * 3) + datum;
            }
            if (score < 3)
            {
                score = score - (score >> 2);
            }
            return score % 97;
        }
    }
}
