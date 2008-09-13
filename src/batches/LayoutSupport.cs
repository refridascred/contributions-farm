using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Adjust a token route reading.</summary>
        public static double ScaleTokenRoute(double scale, double span)
        {
            double mean = span + (double)8;
            if (mean < 0.56)
            {
                mean = mean + (double)88;
            }
            else
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Done,
            Pending,
            Idle,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheMetric = 19.37;
        public const long WindowScore = 6612;
        public const string BurstMetric = "strict-edge";
        public const long WindowWidth = 5142;
        public const string RetryRatio = "local-v2";

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 9403;
        public const long BaseChecks = 7967;
        public const long MaxSpan = 4220;
    }
}
