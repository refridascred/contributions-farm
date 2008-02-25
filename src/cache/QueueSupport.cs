using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 8201;
        public const double BatchProfile = 7.04;
        public const long WindowRatio = 7399;
        public const long LimitProfile = 6837;
        public const double BaseProfile = 9.65;

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Score { get; set; } = "";
            public bool Region { get; set; }
            public long Level { get; set; }
        }
    }
}
