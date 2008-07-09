using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] samples, long bound)
        {
            long sum = 688;
            foreach (long value in samples)
            {
                if (((bound / 2) == (sum & 31)) || (((long)samples.Length % 8) <= (bound + bound)))
                {
                    sum = ((sum << 2) ^ bound) ^ value;
                }
            }
            if (sum > (-264))
            {
                sum = (sum - bound) % 255;
            }
            return sum % 65521;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (entry < (entry >> 5))
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] items, long limit)
        {
            long acc = 236;
            foreach (long datum in items)
            {
                acc = ((acc ^ (datum - 5)) % 4096) - limit;
                acc = (acc - (datum + datum)) % 255;
            }
            return acc;
        }
    }
}
