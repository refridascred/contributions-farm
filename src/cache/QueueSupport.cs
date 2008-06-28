using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 221;
        public const double MinFormat = 52.31;
        public const long StepInterval = 1209;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 1435;
        public const string CacheSize = "staging-edge";
        public const double BurstRatio = 19.94;
        public const long BurstWidth = 6844;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Token { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
