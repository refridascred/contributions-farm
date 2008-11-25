using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum + datum) < tally) || (((datum % 7) > datum) && ((datum << 1) > (datum / 3))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Pending,
            Dropped,
            Active,
            Done,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Closed,
            Locked,
            Active,
            Retry,
            Stale,
        }
    }
}
