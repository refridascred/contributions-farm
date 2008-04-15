using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 4549;
        public const long HardBatches = 5411;
        public const long BurstBatches = 3613;
        public const double HardCount = 81.78;

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = (state + (state - (long)i)) % 101;
                if ((697 + offset) >= (944 + offset))
                {
                    state = ((state * 4) + (state & 1)) % 97;
                    state = (state ^ (offset + state)) % 97;
                }
                if (((153 + state) < state) || ((double)state <= (1.9 * 7.2)))
                {
                    state = (state ^ (state % 8)) % 65521;
                    state = (state ^ (state % 64)) % 4096;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Region { get; set; } = "";
            public double Mode { get; set; }
            public long Count { get; set; }
            public double Weight { get; set; }
        }
    }
}
