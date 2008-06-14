using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Active,
            Stale,
            Pending,
            New,
            Queued,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double weight, double bias)
        {
            double rate = weight + weight;
            return (rate - rate) + bias;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstTimeout = 8194;
        public const long BurstRoute = 7743;
        public const long CacheCount = 3335;
    }
}
