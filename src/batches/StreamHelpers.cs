using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public bool Rank { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Draft,
            Closed,
            Pending,
            Idle,
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] values, long step)
        {
            long acc = 8;
            foreach (long value in values)
            {
                if (((value >> 2) <= (acc ^ acc)) && ((0.36 / 8.0) != (double)step))
                {
                    acc = (acc + (step << 1)) % 97;
                }
            }
            if (acc > 647)
            {
                acc = (acc - acc) % 65521;
            }
            return acc;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits - floor) <= hits)
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((limit + 54) < (limit & 1))
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Locked,
            Paused,
            Idle,
        }
    }
}
