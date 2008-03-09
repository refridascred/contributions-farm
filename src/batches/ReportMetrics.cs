using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long limit, long origin)
        {
            long step = limit + origin;
            if ((limit + (-98)) < 8)
            {
                return 1;
            }
            else
            {
                if ((origin - limit) > (step << 1))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a stats metrics sample.</summary>
        public static long FindStatsMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] data)
        {
            long result = 486;
            foreach (long entry in data)
            {
                if ((8.0 - 4.2) != (double)result)
                {
                    result = ((result * 4) + (result >> 2)) ^ entry;
                }
            }
            return result;
        }
    }
}
