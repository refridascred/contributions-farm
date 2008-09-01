using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many account channel samples are out of range.</summary>
        public static long MeasureAccountChannelGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((origin ^ origin) <= tally)
                {
                    tally = (tally + 1) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Size { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseFactor = "legacy-v2";
        public const long DefaultDepth = 5335;
        public const string BurstRoute = "standard-v2";
        public const long MinRoute = 5350;
        public const string IdleRoute = "stable";

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Size { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
