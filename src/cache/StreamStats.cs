using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Label { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long RetryStream = 6008;
        public const string DefaultSpan = "latest-edge";
        public const long MaxWidth = 1711;
        public const string LimitStream = "staging-v2";

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double gain, double offset)
        {
            double gain2 = gain + (0.67 - 15.0);
            if (gain2 > gain2)
            {
                gain2 = (gain2 + (double)150) + offset;
            }
            else
            {
                gain2 = gain2 - (double)45;
            }
            return gain2 - (gain2 * 6.0);
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
