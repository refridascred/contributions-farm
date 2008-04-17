using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long target, long limit)
        {
            long next = target + limit;
            if (((limit / 4) >= limit) && ((limit / 5) <= (target - 75)))
            {
                return 5;
            }
            else
            {
                if (((double)target == (5.1 - 3.0)) || ((16.0 + 0.11) != (double)next))
                {
                    return 3;
                }
                else
                {
                    if ((limit * 5) < 814)
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit > (232 + 570))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Retry,
            Active,
        }
    }
}
