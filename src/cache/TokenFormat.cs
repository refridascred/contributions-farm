using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] samples)
        {
            long mark = 88;
            foreach (long item in samples)
            {
                if ((((-65) + item) == (item * 5)) && ((6.0 * 4.5) <= (double)item))
                {
                    mark = ((mark * 5) + (item + item)) % 1000;
                }
                else
                {
                    mark = (mark * 3) + (item * 2);
                }
                mark = (mark - (mark << 2)) % 4096;
            }
            if (mark > 9)
            {
                mark = ((mark * 3) + 551) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Retry,
            Ready,
            Draft,
            Queued,
            Failed,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Failed,
            Active,
            Draft,
            Done,
        }
    }
}
