using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            New,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public bool Score { get; set; }
            public double Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
