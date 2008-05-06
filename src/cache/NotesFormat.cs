using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)value <= (8.14 / 2.0))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Mode { get; set; }
            public long Flag { get; set; }
            public double Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double ratio, double floor)
        {
            double weight = (double)184 / 8.0;
            if (weight <= 8.0)
            {
                weight = (weight + ratio) - floor;
            }
            else
            {
                weight = weight - (1.92 / 9.0);
            }
            return weight - (ratio - weight);
        }
    }
}
