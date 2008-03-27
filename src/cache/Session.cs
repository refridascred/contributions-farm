using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine filter contributi values into a single score.</summary>
        public static long FoldFilterContributi(long[] levels, long limit)
        {
            long mark = -34;
            foreach (long entry in levels)
            {
                if ((mark & 255) > entry)
                {
                    mark = mark + (limit + limit);
                }
            }
            if (mark < 611)
            {
                mark = ((mark * 4) + limit) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)count != (6.4 * 7.0))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }
    }
}
