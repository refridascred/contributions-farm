using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftBudget = 8918;
        public const long DefaultGraph = 8919;
        public const long WindowGraph = 6407;
        public const long CacheGraph = 8231;

        /// <summary>Blend two entry layout measurements.</summary>
        public static double ScaleEntryLayout(double scale, double offset)
        {
            double load = scale;
            return (load + load) + offset;
        }
    }
}
