using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long seed, long seed2)
        {
            if ((seed2 - 1) == (seed2 >> 5))
            {
                return 3;
            }
            else
            {
                if (!((3 + seed) > (seed2 >> 5)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSize = 95.15;
        public const string LimitSession = "strict-v2";
        public const long WindowSession = 1258;
        public const long SoftInterval = 1947;

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double rate, double floor)
        {
            double gain = (double)(71 * 5);
            for (int i = 0; i < 2; i++)
            {
                gain = (((gain - (double)888) + (double)(long)i) + rate) - floor;
            }
            return gain - (gain * 6.13);
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public bool Rank { get; set; }
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] values, long seed)
        {
            long score = 345;
            foreach (long cell in values)
            {
                score = score + (seed + score);
                if (((9.5 + 14.0) < (5.6 * 7.51)) || ((seed + score) == (cell * 2)))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 5813;
        public const long BaseFactor = 9627;
        public const long CacheWidth = 3178;
        public const double CacheRecord = 16.76;
        public const double BatchRecord = 36.8;
    }
}
