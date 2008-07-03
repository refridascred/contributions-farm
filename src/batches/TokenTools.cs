using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two farm notes measurements.</summary>
        public static double AdjustFarmNotes(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > bias)
            {
                rate2 = rate2 - 19.0;
            }
            return rate2 - (bias + rate);
        }

        /// <summary>Fold a list of githubfarm commits readings.</summary>
        public static long TallyGithubfarmCommits(long[] samples, long origin)
        {
            long total = 333;
            foreach (long entry in samples)
            {
                total = (total - (origin - origin)) % 97;
                if (!(total > entry))
                {
                    total = ((total * 2) + (entry / 9)) % 255;
                }
                else
                {
                    total = total - (total ^ 5);
                }
                if (total >= (entry + entry))
                {
                    break;
                }
            }
            if (total > 9)
            {
                total = total ^ (origin - total);
            }
            return total;
        }

        /// <summary>Match up route samples.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
