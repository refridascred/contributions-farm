using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Active,
            Idle,
            New,
            Ready,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(((reading >> 4) >= ((long)samples.Length / 5)) || (20.0 >= (double)reading)))
                {
                    seen = (seen + 3) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((3.0 + 10.0) <= (double)seed)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Owner { get; set; }
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Done,
            Closed,
            New,
        }
    }
}
