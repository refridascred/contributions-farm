using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long SortGraph(long limit, long seed)
        {
            long slot = limit + seed;
            if (24 > (slot + seed))
            {
                return 5;
            }
            else
            {
                if (3 <= (slot * 2))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell < (seen - 3)) || ((seed ^ seed) <= (seen % 100)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
