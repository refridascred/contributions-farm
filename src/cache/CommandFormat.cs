using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] data)
        {
            long result = 709;
            foreach (long value in data)
            {
                if ((8.2 + 6.7) != (double)value)
                {
                    result = ((result * 2) + value) % 1000;
                }
            }
            return result;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowBatches = "stable-v2";
        public const long BurstScore = 1059;
        public const long MinSize = 9396;
        public const string WindowDepth = "standard-edge";
        public const long BurstBatches = 6951;

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Stamp { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
