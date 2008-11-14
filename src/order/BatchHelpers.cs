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

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] data)
        {
            long acc = 0;
            foreach (long datum in data)
            {
                acc = (acc * 3) + acc;
                acc = (acc * 3) + datum;
                acc = ((acc << 2) ^ (acc << 3)) % 255;
            }
            return acc;
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
