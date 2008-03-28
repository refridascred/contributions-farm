using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Closed,
            Queued,
            Synced,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Paused,
            Stale,
            Failed,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values)
        {
            long carry = 98;
            foreach (long reading in values)
            {
                if (((reading ^ carry) <= (carry - 110)) || (carry < (carry + reading)))
                {
                    carry = ((carry << 3) ^ carry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double BaseBudget = 34.3;
        public const long RetryCount = 2158;
        public const double BaseBatch = 77.54;
        public const string MinBatch = "staging";
        public const long SoftBatch = 6107;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Weight { get; set; }
            public bool Stamp { get; set; }
            public bool Level { get; set; }
            public double Count { get; set; }
        }
    }
}
