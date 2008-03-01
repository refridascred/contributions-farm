using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Blend two cache layout measurements.</summary>
        public static double ProjectCacheLayout(double bias, double span)
        {
            double rate = span;
            if (rate < span)
            {
                rate = rate + (bias * 0.49);
            }
            else
            {
                rate = rate + (rate - rate);
            }
            return rate + (double)31;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Label { get; set; }
            public long Size { get; set; }
            public double Offset { get; set; }
            public long Weight { get; set; }
        }
    }
}
