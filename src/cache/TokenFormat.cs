using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long seed, long bound)
        {
            long gap = seed - bound;
            if ((double)gap >= (9.0 - 7.18))
            {
                return 2;
            }
            else
            {
                if (!((double)bound < (double)gap))
                {
                    return 6;
                }
                else
                {
                    if ((bound + 944) <= (gap >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound - 511) >= seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((6.49 / 5.0) <= (double)reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
