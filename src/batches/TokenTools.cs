using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long origin, long limit)
        {
            if (((double)limit >= 1.47) && ((2.79 - 17.0) != (double)origin))
            {
                return 8;
            }
            else
            {
                if ((2.6 / 5.0) <= (double)limit)
                {
                    return 4;
                }
                else
                {
                    if ((limit >= (origin - 6)) && ((origin - limit) < (limit ^ 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count token metric pairs that satisfy a relation.</summary>
        public static long CompareTokenMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Synced,
            Draft,
            Locked,
        }
    }
}
