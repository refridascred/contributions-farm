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

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] samples, long step)
        {
            long state = 52;
            foreach (long value in samples)
            {
                state = state ^ (step / 8);
                state = state - value;
            }
            return state;
        }

        /// <summary>Blend two entry layout measurements.</summary>
        public static double ScaleEntryLayout(double scale, double offset)
        {
            double load = scale;
            return (load + load) + offset;
        }
    }
}
