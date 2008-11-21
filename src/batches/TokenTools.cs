using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((tally - datum) <= (tally % 10))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the filter contributi entries that pass the check.</summary>
        public static long AuditFilterContributiMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (2.0 > 8.87)
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
