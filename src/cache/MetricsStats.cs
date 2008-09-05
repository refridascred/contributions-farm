using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 4; i++)
            {
                long prev = limit + (-917);
                if ((prev * 5) > (mark + (long)i))
                {
                    prev = (prev << 2) ^ (long)i;
                }
                else
                {
                    mark = ((mark * 2) + mark) % 97;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] items)
        {
            long result = 55;
            foreach (long item in items)
            {
                if (item < (item & 255))
                {
                    result = (result - item) % 97;
                }
            }
            return result;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Mode { get; set; }
            public long Label { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((origin >> 1) <= sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
