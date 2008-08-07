using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxScore = 6966;
        public const long RetryInterval = 2540;
        public const string BaseReport = "staging";

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double bias, double bias2)
        {
            double rate = 8.0 - bias;
            if (rate >= 1.02)
            {
                rate = (rate + (double)651) + bias2;
            }
            return rate + bias;
        }
    }
}
