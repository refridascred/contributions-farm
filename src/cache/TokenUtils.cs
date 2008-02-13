using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowRatio = 1887;
        public const long RetryGithubfarm = 7327;
        public const string IdleTimeout = "latest-1";

        /// <summary>Blend two queue report measurements.</summary>
        public static double BlendQueueReport(double scale, double bias)
        {
            double gain = (bias + 9.67) - scale;
            return gain + (double)194;
        }
    }
}
