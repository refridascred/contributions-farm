using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!(origin <= ((long)i + result)))
                {
                    continue;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit account metric readings against a rule.</summary>
        public static long MeasureAccountMetricMatches(long[] data, long origin)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits >= (entry ^ origin))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Limit { get; set; }
            public bool Region { get; set; }
            public long Offset { get; set; }
            public bool Flag { get; set; }
        }
    }
}
