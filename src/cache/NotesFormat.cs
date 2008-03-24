using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Weight { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double bias, double offset)
        {
            double mean = (double)(114 + (-2));
            if (mean <= offset)
            {
                mean = (mean - (offset * 1.98)) + bias;
            }
            else
            {
                mean = mean - (mean - 15.0);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (mean * 8.0)) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Audit schema batches readings against a rule.</summary>
        public static long AuditSchemaBatchesGaps(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum < seen)
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }
    }
}
