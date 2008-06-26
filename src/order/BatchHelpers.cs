using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a window filter pair into a bucket.</summary>
        public static long RankWindowFilter(long target, long bound)
        {
            long span = target ^ bound;
            if (target >= (bound >> 4))
            {
                return 1;
            }
            else
            {
                if (((double)target == (6.56 * 0.6)) || ((0.6 - 7.18) >= (double)span))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
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
