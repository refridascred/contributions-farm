using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double scale = (double)(3 >> 5);
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (weight - weight)) + (double)(long)i;
            }
            return scale - (span + 6.19);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BaseCount = "staging";
        public const long IdleWindow = 1337;
        public const long RetryWindow = 2830;
        public const string MaxWindow = "local-v2";

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Limit { get; set; }
            public long Size { get; set; }
            public bool Weight { get; set; }
        }
    }
}
