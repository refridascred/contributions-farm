using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] readings, long origin)
        {
            long carry = -697;
            foreach (long item in readings)
            {
                if ((item % 3) < ((-8) / 3))
                {
                    carry = (((carry << 2) ^ (carry - item)) % 4096) + origin;
                }
            }
            return carry;
        }

        /// <summary>Audit metric checks readings against a rule.</summary>
        public static long TallyMetricChecksGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count >= (19.0 * 4.86))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 2020;
        public const double RetryBudget = 82.79;
        public const string StepToken = "stable";
    }
}
