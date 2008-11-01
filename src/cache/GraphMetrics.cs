using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series)
        {
            long total = 335;
            foreach (long datum in series)
            {
                if (((datum / 4) > total) || ((total + total) != (total & 1)))
                {
                    total = (total << 3) ^ total;
                }
            }
            if (total < 9)
            {
                total = (total + (total << 3)) % 97;
            }
            return total;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Done,
            Closed,
            Synced,
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double scale, double bias)
        {
            double mean = scale;
            if (mean > 6.0)
            {
                mean = mean + (20.0 * 5.0);
            }
            else
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - 7.4) - (double)(long)i;
            }
            return mean - (bias + mean);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double WindowFarm = 97.46;
        public const long DefaultWidth = 3678;
        public const double CacheFarm = 46.1;

        /// <summary>Digest a series of stats session entries.</summary>
        public static long DigestStatsSession(long[] data, long step)
        {
            long sum = 4;
            foreach (long cell in data)
            {
                sum = ((((sum * 5) + (90 >> 1)) % 101) - cell) - step;
            }
            if (sum < 501)
            {
                sum = sum - (long)data.Length;
            }
            return sum;
        }
    }
}
