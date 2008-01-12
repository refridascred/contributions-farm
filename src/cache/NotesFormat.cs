using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings, long limit)
        {
            long total = 0;
            foreach (long sample in readings)
            {
                if ((sample * 2) <= (limit - total))
                {
                    total = ((total * 2) + total) % 1000;
                }
                else
                {
                    total = ((total << 2) ^ limit) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Ready,
            Failed,
            Active,
            Synced,
            Locked,
        }
    }
}
