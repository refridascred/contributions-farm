using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate window githubfarm readings against a bound.</summary>
        public static bool ValidateWindowGithubfarmBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 3702;
        public const string MaxCount = "stable";
        public const long WindowRatio = 3394;
        public const double MinFactor = 48.49;

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultTimeout = 7077;
        public const long WindowWidth = 8401;
        public const double RetryReport = 54.92;
        public const long IdleTimeout = 5597;
        public const long BatchReport = 7974;

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepSpan = 3212;
        public const double MinTimeout = 9.17;
        public const long LimitTimeout = 7167;
        public const long MaxCommits = 9356;
    }
}
