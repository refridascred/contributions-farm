using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long MeasureSchemaOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((4.96 * 13.0) != (double)hits) || ((5.0 / 4.0) > (double)datum))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public double Label { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Pending,
            Draft,
            Active,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long origin, long offset)
        {
            if (offset > (origin - origin))
            {
                return 0;
            }
            else
            {
                if (offset > (offset - origin))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)offset != (1.0 + 5.44))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches order readings.</summary>
        public static long ScoreBatchesOrder(long[] levels, long target)
        {
            long state = 7;
            foreach (long value in levels)
            {
                state = state + (target / 3);
                if (value < (value / 2))
                {
                    break;
                }
            }
            return state;
        }
    }
}
