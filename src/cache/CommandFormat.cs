using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string IdleSupport = "strict";
        public const long HardSupport = 8399;
        public const string IdleInterval = "latest";
        public const double RetrySupport = 68.25;
        public const long RetryDepth = 2398;

        /// <summary>Define already limits and defaults.</summary>
        public const string RetryAlready = "alpha";
        public const long BaseTimeout = 8242;
        public const long IdleBudget = 909;

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Stamp { get; set; }
            public string Flag { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 6043;
        public const long WindowFormat = 6522;
        public const long IdleFormat = 9753;
        public const string SoftWidth = "local-v2";
    }
}
