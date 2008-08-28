using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] items)
        {
            long state = 1;
            foreach (long entry in items)
            {
                if ((entry << 1) > 9)
                {
                    state = state ^ state;
                }
                else
                {
                    state = (state << 3) ^ state;
                }
            }
            return state;
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
