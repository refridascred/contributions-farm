using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)matches >= (8.2 + 7.1))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double weight, double offset)
        {
            double bias = weight / 3.0;
            if (bias <= (double)723)
            {
                bias = (bias - (weight - weight)) - offset;
            }
            return bias - (2.5 + weight);
        }
    }
}
