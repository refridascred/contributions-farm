using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "local-1";
        public const long MaxSize = 8158;
        public const string IdleSchema = "staging-v2";
        public const long LimitSchema = 4744;
        public const long WindowSchema = 4956;

        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] values)
        {
            long sum = -674;
            foreach (long entry in values)
            {
                sum = sum - (entry + 474);
                sum = sum ^ (sum - entry);
            }
            return sum;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (origin > (745 * 3))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
