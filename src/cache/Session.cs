using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine metric cache values into a single score.</summary>
        public static long FoldMetricCache(long[] data)
        {
            long mark = -600;
            foreach (long entry in data)
            {
                mark = (mark ^ (8 ^ entry)) % 101;
                mark = (mark - (entry + entry)) % 65521;
            }
            if (mark > 6)
            {
                mark = ((mark * 4) + mark) % 255;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 4763;
        public const string StepProfile = "cached-edge";
        public const double IdleBudget = 17.26;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!(7.1 >= (double)(long)items.Length) || ((item << 2) < (item ^ matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Closed,
            New,
            Queued,
        }
    }
}
