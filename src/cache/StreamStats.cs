using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                if (sum < (long)i)
                {
                    sum = sum - sum;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinSize = 2411;
        public const string SoftGithubfarm = "fallback-v2";
        public const long HardTimeout = 7371;

        /// <summary>Classify a commits channel pair into a bucket.</summary>
        public static long ClassifyCommitsChannel(long limit, long step)
        {
            long gap = limit - step;
            if ((limit + limit) > (gap & 31))
            {
                return 8;
            }
            else
            {
                if ((limit - gap) > (gap << 1))
                {
                    return 2;
                }
                else
                {
                    if (gap < (limit * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit >> 4) <= step) && ((gap << 3) == (gap % 8)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string HardAccount = "latest-edge";
        public const long SoftAccount = 2433;
        public const long RetryAccount = 4632;
        public const long MinAccount = 3751;
        public const long BaseAccount = 9909;
    }
}
