using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Iterate the batches tools series from a seed.</summary>
        public static long SeriesBatchesTools(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                if (((state & 7) == ((long)i + state)) || ((seed ^ seed) > (seed % 12)))
                {
                    state = ((state << 2) ^ state) % 97;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
