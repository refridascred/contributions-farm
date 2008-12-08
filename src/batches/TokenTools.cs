using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Ready,
            New,
            Stale,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string IdleSize = "local-v2";
        public const long BaseAlready = 168;
        public const long WindowAlready = 1614;
        public const string WindowTimeout = "cached-v2";

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double bias, double span)
        {
            double mean = (13.0 - 11.0) + span;
            return (mean + mean) + bias;
        }
    }
}
