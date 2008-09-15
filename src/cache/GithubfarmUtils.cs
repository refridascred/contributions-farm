using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
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
