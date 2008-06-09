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

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] values)
        {
            long mark = 29;
            foreach (long reading in values)
            {
                for (int i = 0; i < 3; i++)
                {
                    mark = (((mark ^ (mark >> 4)) % 97) - (long)i) ^ reading;
                }
                mark = (mark + (mark & 127)) % 4096;
            }
            return mark;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 7474;
        public const long SoftWidth = 7438;
        public const long CacheTools = 2652;
        public const double IdleScore = 74.15;
        public const double IdleFactor = 74.13;
    }
}
