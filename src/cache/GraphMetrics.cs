using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Token { get; set; }
            public double Label { get; set; }
            public long Total { get; set; }
            public long Size { get; set; }
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
