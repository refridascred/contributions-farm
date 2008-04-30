using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "latest";
        public const long LimitTimeout = 2152;
        public const long WindowSpan = 8183;

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Total { get; set; } = "";
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                if (((double)offset >= (double)state) && (5 > (long)i))
                {
                    state = state - (state - offset);
                }
                else
                {
                    state = (state ^ (long)i) % 97;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
