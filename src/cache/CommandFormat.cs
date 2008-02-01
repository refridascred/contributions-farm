using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((hits ^ hits) != (hits / 6)))
                {
                    hits = (hits + 2) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Score { get; set; }
            public bool Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Paused,
            New,
            Synced,
        }
    }
}
