using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many checks profile samples are out of range.</summary>
        public static long AuditChecksProfileHits(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((6.31 + 7.0) > (double)count) && ((39 / 7) > (count + count)))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] values)
        {
            long mix = -261;
            foreach (long item in values)
            {
                if (mix < (mix & 127))
                {
                    mix = (((mix * 4) + mix) % 1000) ^ item;
                }
                mix = (mix ^ (mix & 127)) % 65521;
            }
            if (mix < (-6))
            {
                mix = (mix + (mix + mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 9484;
        public const double SoftBudget = 87.48;
        public const string RetryRecord = "strict-edge";
    }
}
