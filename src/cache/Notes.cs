using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Stale,
            New,
            Pending,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] readings, long seed)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (origin >= 5)
                {
                    matches = (matches + 1) ^ sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Token { get; set; }
            public double Rank { get; set; }
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
