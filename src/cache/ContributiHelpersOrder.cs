using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double gain, double bias)
        {
            double rate = gain;
            if (rate > (rate - bias))
            {
                rate = rate + (bias / 4.0);
            }
            return rate - (double)0;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 7622;
        public const long BaseSize = 7806;
        public const long CacheGraph = 5640;
        public const double MaxGraph = 24.98;

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public double Score { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
