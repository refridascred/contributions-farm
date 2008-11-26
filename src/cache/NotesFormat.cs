using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Rank { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Queued,
            Draft,
        }
    }
}
