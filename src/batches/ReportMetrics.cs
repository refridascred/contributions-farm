using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((double)cell <= (8.1 / 6.0)) || ((5 + cell) <= (floor / 5)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Queued,
            Retry,
            Dropped,
        }
    }
}
