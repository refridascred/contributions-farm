using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Ready,
            Active,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches - 893) < (-7))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
