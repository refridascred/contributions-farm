using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next commits report value from a seed.</summary>
        public static long StepCommitsReport(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i / 7) > (carry + seed))
                {
                    carry = (carry ^ (913 - seed)) % 4096;
                }
                else
                {
                    carry = (carry * 4) + (carry >> 2);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate metrics queue readings against a bound.</summary>
        public static bool CheckMetricsQueueBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            New,
            Dropped,
            Closed,
        }
    }
}
