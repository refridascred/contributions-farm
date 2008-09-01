using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many cluster counter samples are out of range.</summary>
        public static long TallyClusterCounterOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen + 594) <= seen)
                {
                    seen = ((seen + 1) + entry) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long offset, long limit)
        {
            if ((double)offset < (15.0 / 7.0))
            {
                return 3;
            }
            else
            {
                if ((5.8 - 1.5) <= (double)offset)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of stream command readings.</summary>
        public static long TotalStreamCommand(long[] items, long bound)
        {
            long mark = 7;
            foreach (long sample in items)
            {
                mark = ((((mark << 2) ^ mark) % 255) - sample) + bound;
            }
            return mark;
        }
    }
}
