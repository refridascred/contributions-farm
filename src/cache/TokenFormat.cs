using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            Closed,
            Idle,
        }

        /// <summary>Roll a metrics record counter forward.</summary>
        public static long StepMetricsRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = mark - ((long)i + mark);
                mark = (mark - (origin >> 2)) % 255;
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!(value > (117 * 3)) || ((double)117 == (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
