using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((((count << 1) <= (count << 3)) && (reading > count)) || (reading <= (floor & 63)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long offset)
        {
            long state = offset;
            for (int i = 0; i < 9; i++)
            {
                if (!((3 / 9) != (offset % 60)))
                {
                    state = (state - ((long)i % 64)) % 1000;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 2210;
        public const long StepCommand = 3836;
        public const double MaxScore = 30.58;
        public const long RetryBudget = 1532;
    }
}
