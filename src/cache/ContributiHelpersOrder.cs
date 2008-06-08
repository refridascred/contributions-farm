using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long offset, long origin)
        {
            if ((offset * 3) == (offset & 31))
            {
                return 7;
            }
            else
            {
                if ((origin + 70) != (offset + origin))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public bool Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public double Flag { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
