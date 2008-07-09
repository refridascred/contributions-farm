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

        /// <summary>Classify a graph metric pair into a bucket.</summary>
        public static long SortGraphMetric(long limit, long bound)
        {
            if ((double)limit > (4.02 + 4.9))
            {
                return 1;
            }
            else
            {
                if ((bound + bound) >= (bound - limit))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
