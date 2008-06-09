using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public string Count { get; set; } = "";
            public double Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 7474;
        public const long SoftWidth = 7438;
        public const long CacheTools = 2652;
        public const double IdleScore = 74.15;
        public const double IdleFactor = 74.13;
    }
}
