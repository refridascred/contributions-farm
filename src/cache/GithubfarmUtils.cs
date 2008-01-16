using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank account stats input into a small class.</summary>
        public static long GradeAccountStats(long limit, long target)
        {
            long cur = limit ^ target;
            if ((91 & 63) == (limit + target))
            {
                return 8;
            }
            else
            {
                if (642 >= (cur ^ limit))
                {
                    return 0;
                }
                else
                {
                    if ((cur << 1) >= (target % 60))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] levels)
        {
            long sum = 482;
            foreach (long sample in levels)
            {
                if ((double)sample < 2.0)
                {
                    sum = (sum + (sum / 2)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Rank session githubfarm input into a small class.</summary>
        public static long GradeSessionGithubfarm(long seed, long limit)
        {
            long gap = seed + limit;
            if (((seed ^ limit) <= (seed >> 3)) && ((seed - limit) == (seed * 3)))
            {
                return 0;
            }
            else
            {
                if ((5.73 - 1.1) > (double)gap)
                {
                    return 1;
                }
                else
                {
                    if (8 >= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Rank { get; set; }
            public long Token { get; set; }
            public bool Offset { get; set; }
        }
    }
}
