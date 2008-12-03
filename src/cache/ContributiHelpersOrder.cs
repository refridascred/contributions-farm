using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Failed,
            Synced,
            Active,
            Done,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
            public bool Level { get; set; }
        }
    }
}
