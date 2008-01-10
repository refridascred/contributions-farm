using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double gain, double span)
        {
            double mean = 6.2;
            if (mean >= (span / 6.0))
            {
                mean = mean + span;
            }
            return mean + gain;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Rank { get; set; }
            public bool Total { get; set; }
            public bool Ratio { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitScore = 8356;
        public const double LimitTools = 82.52;
        public const double RetryScore = 48.17;

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryWidth = 4063;
        public const string WindowTimeout = "alpha";
        public const double HardFarm = 75.79;
    }
}
