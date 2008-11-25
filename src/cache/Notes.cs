using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!(value < tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Draft,
            New,
            Locked,
            Dropped,
        }

        /// <summary>Roll a filter batches counter forward.</summary>
        public static long SeriesFilterBatches(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry ^ (carry << 3)) % 97;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Retry,
            Idle,
            Queued,
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
