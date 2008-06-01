using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((limit <= mark) || (limit > (mark - mark)))
                {
                    long diff = mark;
                    mark = mark - diff;
                }
                mark = (mark + 95) % 97;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many metrics already samples are out of range.</summary>
        public static long AuditMetricsAlreadyOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (entry >= (entry & 15))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] items)
        {
            long carry = 139;
            foreach (long entry in items)
            {
                if ((carry >> 2) != ((-7) * 4))
                {
                    carry = ((carry << 2) ^ (carry + 562)) + entry;
                }
                else
                {
                    carry = ((carry << 2) ^ (carry >> 1)) % 255;
                }
            }
            return carry;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Dropped,
            Closed,
            Ready,
            Retry,
            Synced,
        }
    }
}
