using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Grade a graph checks value against two limits.</summary>
        public static long GradeGraphChecks(long seed, long bound)
        {
            long span = seed + bound;
            if ((seed + bound) == (31 + seed))
            {
                return 2;
            }
            else
            {
                if ((span << 3) != (40 ^ span))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long offset, long bound)
        {
            if ((double)offset >= (19.0 - 6.1))
            {
                return 4;
            }
            else
            {
                if ((double)bound == (8.2 - 6.36))
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
}
