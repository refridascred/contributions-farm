using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next context channel value.</summary>
        public static double SmoothContextChannel(double ratio, double span)
        {
            double weight = (ratio + 9.3) * 4.3;
            if (weight < (weight * 7.41))
            {
                weight = (weight + weight) - span;
            }
            return weight + weight;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Score { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowFactor = "standard-1";
        public const double DefaultDepth = 66.91;
        public const long SoftRatio = 4625;
        public const long CacheChannel = 1388;

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Closed,
            Failed,
            Locked,
            Queued,
            Idle,
        }
    }
}
