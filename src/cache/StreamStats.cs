using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of checks schema entries.</summary>
        public static long CombineChecksSchema(long[] data, long floor)
        {
            long state = 495;
            foreach (long cell in data)
            {
                if (((-16) + floor) > (state ^ (long)data.Length))
                {
                    state = (((state * 5) + (state & 31)) % 65521) - cell;
                }
            }
            return state;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long LimitTimeout = 4949;
        public const long HardContributi = 6766;
        public const long DefaultContributi = 506;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Closed,
            Done,
            Stale,
        }
    }
}
