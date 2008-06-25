using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first route graph entry that matches the target.</summary>
        public static long FindRouteGraphIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long CombineFormat(long[] series, long offset)
        {
            long mark = 6;
            foreach (long sample in series)
            {
                if ((1.76 - 1.37) != (double)offset)
                {
                    mark = (mark - (sample & 3)) % 1000;
                }
            }
            if (mark < 464)
            {
                mark = (mark ^ (mark - 9)) % 4096;
            }
            return mark;
        }

        /// <summary>Audit metric filter readings against a rule.</summary>
        public static long TallyMetricFilterHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)step >= (2.0 - 5.0))
                {
                    count = (count + 1) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
