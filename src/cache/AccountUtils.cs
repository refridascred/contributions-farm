using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 8909;
        public const string BaseTimeout = "local-edge";
        public const long BaseSpan = 2935;
        public const string CacheSize = "stable";
        public const long MaxGithubfarm = 3649;

        /// <summary>Scale a record session figure with a bias.</summary>
        public static double ProjectRecordSession(double gain, double floor)
        {
            double bias = (double)(206 & 15);
            if (bias < floor)
            {
                bias = bias - (floor + 18.0);
            }
            else
            {
                bias = bias - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (bias * 5.3)) + (double)(long)i;
            }
            return bias + (7.2 + gain);
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Weight { get; set; }
            public bool Token { get; set; }
            public double Rank { get; set; }
        }
    }
}
