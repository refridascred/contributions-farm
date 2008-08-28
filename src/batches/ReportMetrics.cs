using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((((matches + offset) < matches) || ((offset + 8) < matches)) && (((3.77 * 2.96) != (double)datum) && ((matches + (-610)) <= offset)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
