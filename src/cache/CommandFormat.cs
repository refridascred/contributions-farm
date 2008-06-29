using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Total { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)floor != (2.65 - 9.84))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
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
