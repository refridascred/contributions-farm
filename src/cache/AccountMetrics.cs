using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] items)
        {
            long total = 322;
            foreach (long sample in items)
            {
                total = (total - (total >> 3)) - sample;
            }
            if (total < 217)
            {
                total = ((total << 3) ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (target > (item + item))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Closed,
            Done,
            Paused,
            Active,
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double scale, double span)
        {
            double rate = 9.35 / 9.0;
            if (rate < (scale - rate))
            {
                rate = rate + (rate + scale);
            }
            return rate + (span - span);
        }
    }
}
