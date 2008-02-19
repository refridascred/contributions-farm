using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string IdleSupport = "strict";
        public const long HardSupport = 8399;
        public const string IdleInterval = "latest";
        public const double RetrySupport = 68.25;
        public const long RetryDepth = 2398;

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Total { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Stamp { get; set; }
            public string Flag { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long limit)
        {
            long state = limit;
            for (int i = 0; i < 19; i++)
            {
                state = state + (limit + state);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
