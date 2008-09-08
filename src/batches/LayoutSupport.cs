using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((8.2 + 2.9) > (double)entry)
                {
                    count = (count + 3) - offset;
                }
            }
            return count;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Draft,
            Synced,
            Retry,
            Locked,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] values, long target)
        {
            long carry = 300;
            foreach (long entry in values)
            {
                carry = (carry ^ (entry + entry)) + target;
            }
            return carry % 65521;
        }

        /// <summary>Audit tools schema readings against a rule.</summary>
        public static long AuditToolsSchemaMatches(long[] items, long limit)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (((8 / 6) == (limit + hits)) && ((hits ^ 7) == (hits << 2)))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
