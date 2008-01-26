using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 6868;
        public const double IdleFilter = 56.51;
        public const long CacheFilter = 9898;
        public const string BatchScore = "open-edge";

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double rate, double span)
        {
            double drift = span - (rate * 7.2);
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift - (drift - rate);
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleFactor = 59.53;
        public const long BaseCommits = 6133;
        public const double SoftCommits = 86.05;
        public const long DefaultCommits = 894;
        public const long CacheScore = 1789;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
