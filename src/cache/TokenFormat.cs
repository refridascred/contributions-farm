using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((12.0 / 4.0) != (double)seen)
                {
                    seen = ((seen + 2) ^ item) + bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long CombineQueue(long[] series)
        {
            long total = 13;
            foreach (long cell in series)
            {
                total = ((total << 2) ^ cell) % 1000;
                if (cell < (total % 64))
                {
                    break;
                }
            }
            return total;
        }
    }
}
