using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((7.6 * 9.4) != (double)cell)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string StepSchema = "fallback-v2";
        public const long MaxSchema = 5966;
        public const long RetryTimeout = 4465;
        public const string MinSchema = "open-1";
    }
}
