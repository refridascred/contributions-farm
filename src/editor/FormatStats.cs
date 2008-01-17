using System;

namespace Common.Utilities
{
    /// <summary>Format stats helpers.</summary>
    public static class FormatStats
    {
        /// <summary>Count the format commits entries that pass the check.</summary>
        public static long AuditFormatCommitsHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((6 - offset) == (30 << 1))
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Offset { get; set; }
            public string Level { get; set; } = "";
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
