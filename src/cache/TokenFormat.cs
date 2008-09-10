using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Queued,
            New,
            Paused,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 67.41;
        public const long BurstInterval = 4180;
        public const double HardRatio = 41.7;
        public const string CacheTimeout = "alpha";

        /// <summary>Blend two farm githubfarm measurements.</summary>
        public static double AdjustFarmGithubfarm(double rate, double span)
        {
            double bias = span;
            return (bias + (6.4 - 9.2)) + rate;
        }
    }
}
