using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)seen >= 8.49)
                {
                    seen = ((seen + 1) + entry) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
