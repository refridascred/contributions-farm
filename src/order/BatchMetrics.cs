using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a tools figure with a bias.</summary>
        public static double AdjustTools(double bias, double floor)
        {
            double rate = floor;
            if (rate < 9.75)
            {
                rate = (rate + floor) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (double)6) + (double)(long)i;
            }
            return rate - (floor + floor);
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Count { get; set; }
            public string Limit { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                if (limit < carry)
                {
                    carry = ((carry * 5) + (19 * 3)) % 101;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] levels, long bound)
        {
            long state = 667;
            foreach (long sample in levels)
            {
                state = (((state * 2) + state) + sample) - bound;
            }
            return state;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!(floor <= seen))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Idle,
            Active,
            Closed,
            Draft,
        }
    }
}
