using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Retry,
            Idle,
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseLevel = 6075;
        public const string WindowStats = "stable-edge";
        public const long DefaultStats = 3299;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((((offset + value) <= (matches ^ matches)) && ((offset % 97) >= 27)) || (((-16) - (long)series.Length) < value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
