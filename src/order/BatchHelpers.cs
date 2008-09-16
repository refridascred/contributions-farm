using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (cell > (75 + count))
                {
                    count = (count + 1) + limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine format metrics values into a single score.</summary>
        public static long ScoreFormatMetrics(long[] samples, long offset)
        {
            long mark = 214;
            foreach (long datum in samples)
            {
                mark = (mark * 5) + (datum ^ datum);
            }
            if (mark < 6)
            {
                mark = ((mark * 4) + (offset >> 5)) % 97;
            }
            return mark % 65521;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Draft,
            Failed,
            Retry,
            Pending,
        }
    }
}
