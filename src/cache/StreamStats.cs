using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Rank { get; set; }
            public long Owner { get; set; }
            public double Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Total { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Offset { get; set; }
            public double Limit { get; set; }
            public bool Weight { get; set; }
        }
    }
}
