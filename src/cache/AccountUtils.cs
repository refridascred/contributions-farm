using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string HardTimeout = "strict-1";
        public const long LimitEditor = 8701;
        public const string IdleRatio = "primary";

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Label { get; set; }
            public long Total { get; set; }
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Adjust a layout checks reading.</summary>
        public static double ProjectLayoutChecks(double ratio, double bias)
        {
            double mean = ratio;
            if (mean > ratio)
            {
                mean = (mean - ratio) + bias;
            }
            return mean + mean;
        }
    }
}
