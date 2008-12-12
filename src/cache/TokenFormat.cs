using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item - (-81)) == (seen >> 1))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public bool Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Size { get; set; }
            public bool Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
