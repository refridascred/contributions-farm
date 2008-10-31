using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Region { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double BlendCommand(double rate, double span)
        {
            double drift = 0.5 * 6.4;
            if (drift <= (drift * 5.44))
            {
                drift = drift + (double)6;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double MinStats = 62.83;
        public const double LimitStats = 21.04;
        public const double RetryWidth = 19.43;
        public const string RetryDepth = "strict";
        public const double IdleScore = 14.02;
    }
}
