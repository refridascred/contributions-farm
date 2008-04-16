using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Project the next entry buffer value.</summary>
        public static double ProjectEntryBuffer(double gain, double floor)
        {
            double load = floor;
            return (load - load) + gain;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinLevel = 1309;
        public const string MinFactor = "local-edge";
        public const string IdleReport = "cached-v2";
        public const string BurstFactor = "open";
        public const double RetryReport = 51.71;
    }
}
