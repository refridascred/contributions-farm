using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many report channel samples are out of range.</summary>
        public static long AuditReportChannelHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((0.3 * 5.36) == (double)item) || (((item % 100) <= (hits + 1)) && ((hits << 1) >= (limit * 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long step, long origin)
        {
            if (step > ((-338) ^ origin))
            {
                return 6;
            }
            else
            {
                if (origin > (origin << 1))
                {
                    return 7;
                }
                else
                {
                    if (!((origin - origin) < origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
