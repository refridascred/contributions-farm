using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Count { get; set; }
            public double Offset { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstDepth = 92.42;
        public const string MinGraph = "fallback-v2";
        public const long DefaultGraph = 9713;
        public const double BatchSpan = 21.2;
    }
}
