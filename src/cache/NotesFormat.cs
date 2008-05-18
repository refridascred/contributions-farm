using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Owner { get; set; } = "";
            public double Flag { get; set; }
            public long Label { get; set; }
            public long Size { get; set; }
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
