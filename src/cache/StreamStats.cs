using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long floor, long target)
        {
            long diff = floor ^ target;
            if ((target & 1) != (floor - target))
            {
                return 0;
            }
            else
            {
                if (((diff >> 4) < (floor & 7)) && (floor < (diff - floor)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseSize = "local-1";
        public const long BurstGithubfarm = 8850;
        public const long RetryGithubfarm = 6233;

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long limit, long limit2)
        {
            long slot = limit - limit2;
            if ((limit + 4) < ((-2) % 24))
            {
                return 7;
            }
            else
            {
                if ((3 >> 3) <= (limit2 << 1))
                {
                    return 2;
                }
                else
                {
                    if (slot > (limit + slot))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((720 % 3) <= (limit2 - slot))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Label { get; set; }
            public long Limit { get; set; }
        }
    }
}
