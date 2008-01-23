using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Size { get; set; } = "";
            public double Mode { get; set; }
            public double Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryFactor = 78.86;
        public const long DefaultFactor = 1797;
        public const long MinRatio = 9066;

        /// <summary>Roll a route githubfarm counter forward.</summary>
        public static long IterateRouteGithubfarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Project the next commits graph value.</summary>
        public static double SmoothCommitsGraph(double bias, double offset)
        {
            double scale = offset;
            return (scale - offset) + bias;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinTimeout = 8445;
        public const double BatchReport = 54.46;
        public const long SoftDepth = 7658;
        public const long MinCount = 3100;
        public const long HardTimeout = 7438;
    }
}
