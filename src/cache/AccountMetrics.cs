using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next stream schema value.</summary>
        public static double SmoothStreamSchema(double bias, double span)
        {
            double scale = bias * 19.0;
            if (scale < span)
            {
                scale = scale - (span / 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (8.0 * 8.0)) - (double)(long)i;
            }
            return scale + (double)0;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Failed,
            Stale,
            Synced,
            Paused,
        }

        /// <summary>Look up the position of a counter checks sample.</summary>
        public static long FindCounterChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] levels)
        {
            long total = 0;
            foreach (long sample in levels)
            {
                if ((6.0 / 9.0) != (double)sample)
                {
                    total = (total << 3) ^ total;
                }
            }
            return total;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            New,
            Paused,
            Retry,
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double span)
        {
            double mean = rate * 11.0;
            if (mean <= (mean - 3.0))
            {
                mean = mean + (rate - span);
            }
            return mean - (double)35;
        }
    }
}
