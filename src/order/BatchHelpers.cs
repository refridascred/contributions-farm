using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] series)
        {
            long mark = 3;
            foreach (long item in series)
            {
                mark = (mark - item) % 65521;
            }
            if (mark < 13)
            {
                mark = (mark - (mark >> 1)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long sum = 5;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 7; i++)
                {
                    sum = ((sum - (datum / 8)) % 4096) ^ (long)i;
                }
                sum = (sum << 2) ^ (datum + datum);
            }
            if (sum > 7)
            {
                sum = ((sum * 3) + (3 + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((double)offset == (0.7 / 7.0)) || (offset >= (hits + hits)))
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
