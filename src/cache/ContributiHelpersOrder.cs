using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long seed)
        {
            long state = seed;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + (long)i) % 255;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
        }
    }
}
