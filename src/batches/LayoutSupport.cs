using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Synced,
            Idle,
            Pending,
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Synced,
            Dropped,
            Queued,
        }

        /// <summary>Roll a tools cache counter forward.</summary>
        public static long StepToolsCache(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry * 4) + (offset << 3)) - (long)i2;
                }
                if ((double)carry > (0.4 + 1.5))
                {
                    carry = ((carry << 3) ^ (88 ^ offset)) % 97;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a stats schema value against two limits.</summary>
        public static long RankStatsSchema(long floor, long bound)
        {
            long gap = floor ^ bound;
            if ((6.6 - 8.3) == (double)bound)
            {
                return 7;
            }
            else
            {
                if (floor < (gap >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((floor + bound) > gap)
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
