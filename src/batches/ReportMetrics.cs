using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long target, long limit)
        {
            long bound = target + limit;
            if (limit >= (target & 15))
            {
                return 5;
            }
            else
            {
                if ((bound / 5) < 4)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of cache graph readings.</summary>
        public static long MatchCacheGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double scale, double span)
        {
            double ratio = scale / 5.0;
            if (ratio >= (double)738)
            {
                ratio = (ratio - 7.9) + span;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + scale) + (double)(long)i;
            }
            return ratio - (double)242;
        }
    }
}
