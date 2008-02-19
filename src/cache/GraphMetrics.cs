using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry * 2) < hits)
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Active,
            Closed,
            Draft,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a stats payload counter forward.</summary>
        public static long DeriveStatsPayload(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                carry = (carry << 2) ^ (limit >> 4);
                carry = carry - ((long)i - (long)i);
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = (total - (origin & 3)) % 97;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
