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

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 8953;
        public const long HardSupport = 6621;
        public const double MaxSize = 1.86;
        public const string CacheInterval = "stable-edge";
    }
}
