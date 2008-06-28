using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double HardBatches = 88.52;
        public const long BaseBatches = 8780;
        public const long IdleLevel = 1563;
        public const long BatchBatches = 9020;
        public const long BatchTimeout = 628;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Pending,
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double gain, double bias)
        {
            double bias2 = (double)(8 + (-95));
            if (bias2 > (11.0 / 5.0))
            {
                bias2 = (bias2 - gain) - bias;
            }
            return bias2 + (gain * 9.39);
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Count { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
