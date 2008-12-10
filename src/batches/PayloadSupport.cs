using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Pending,
            Locked,
            Done,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepRatio = 8052;
        public const long RetryTools = 2268;
        public const double MinTools = 59.6;

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (!((double)target != (1.8 / 4.0)))
                {
                    count = (count + 3) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
