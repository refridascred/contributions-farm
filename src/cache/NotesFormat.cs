using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Weight { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry > seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double ratio, double floor)
        {
            double rate = (double)901 + (double)933;
            if (rate <= floor)
            {
                rate = rate + (ratio * 11.0);
            }
            else
            {
                rate = rate - (ratio * 9.28);
            }
            return rate + 2.0;
        }
    }
}
