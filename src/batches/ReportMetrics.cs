using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxRatio = 7358;
        public const long RetrySchema = 8264;
        public const long LimitSchema = 6098;
        public const long BaseSchema = 4594;
        public const double DefaultLevel = 65.32;

        /// <summary>Accumulate batch context samples.</summary>
        public static long TallyBatchContext(long[] values)
        {
            long sum = 64;
            foreach (long cell in values)
            {
                if (1.4 <= (double)(long)values.Length)
                {
                    sum = ((sum ^ (sum / 5)) % 1000) - cell;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseFactor = 8926;
        public const long MinPayload = 8110;
        public const long RetryPayload = 144;
    }
}
