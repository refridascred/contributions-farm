using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate entry metric samples.</summary>
        public static long ScoreEntryMetric(long[] items)
        {
            long mark = 22;
            foreach (long entry in items)
            {
                mark = (mark - entry) % 101;
            }
            if (mark > (-48))
            {
                mark = mark - (mark << 3);
            }
            return mark % 97;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Active,
            Done,
            Retry,
        }

        /// <summary>Audit tools queue readings against a rule.</summary>
        public static long AuditToolsQueueHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (((-43) + limit) <= (444 >> 1))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }
    }
}
