using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double BurstBudget = 14.38;
        public const long SoftContext = 5552;
        public const long BurstInterval = 2874;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 27.78;
        public const long DefaultSize = 9544;
        public const string MinCluster = "alpha-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseRoute = "open";
        public const double SoftRatio = 68.42;
        public const long WindowRoute = 6545;
        public const long BurstFactor = 4310;
        public const double HardScore = 29.66;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
