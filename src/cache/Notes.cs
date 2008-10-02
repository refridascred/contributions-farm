using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            New,
            Closed,
            Active,
            Retry,
            Paused,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double weight, double span)
        {
            double scale = weight;
            if (scale > span)
            {
                scale = scale + weight;
            }
            else
            {
                scale = scale + scale;
            }
            return scale + (double)3;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheBudget = "alpha";
        public const long MaxContext = 8778;
        public const long WindowContext = 2306;
        public const string SoftContext = "stable-v2";

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 7534;
        public const string BurstSession = "staging";
        public const long WindowWidth = 5042;
        public const long MaxDepth = 2261;
        public const long CacheSession = 7465;
    }
}
