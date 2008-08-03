using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Limit { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCommits = 97.84;
        public const string MaxCommits = "fallback";
        public const string WindowCommits = "latest-edge";

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Size { get; set; }
            public double Flag { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long floor)
        {
            if ((floor & 63) > (floor >> 3))
            {
                return 4;
            }
            else
            {
                if ((3.0 / 8.0) == (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((limit + floor) > (98 % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
