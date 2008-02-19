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

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] values, long target)
        {
            long mix = 9;
            foreach (long value in values)
            {
                mix = (mix ^ (value / 8)) - target;
                mix = ((mix * 5) + (2 % 3)) % 4096;
            }
            return mix % 1000;
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
