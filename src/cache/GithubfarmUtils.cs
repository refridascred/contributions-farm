using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a profile account pair into a bucket.</summary>
        public static long RankProfileAccount(long limit, long offset)
        {
            long edge = limit - offset;
            if ((275 - (-377)) == (edge + 20))
            {
                return 5;
            }
            else
            {
                if ((9.79 / 6.0) < (double)edge)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxFactor = "alpha-1";
        public const long HardWidth = 8076;
        public const string BatchRoute = "stable-edge";
        public const long IdleRoute = 9423;
        public const long BurstRoute = 7318;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public long Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Limit { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
