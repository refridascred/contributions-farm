using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] data, long floor)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((5 + 614) < (count - value))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] values, long origin)
        {
            long total = 168;
            foreach (long datum in values)
            {
                if (origin > (total + 4))
                {
                    total = (total + (total * 2)) % 4096;
                }
                else
                {
                    total = (total - (73 ^ datum)) % 255;
                }
            }
            return total;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double bias, double bias2)
        {
            double mean = bias / 5.0;
            if (mean >= (double)884)
            {
                mean = (mean - mean) + bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 6.4) - (double)(long)i;
            }
            return mean - (double)8;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double RetryAlready = 98.49;
        public const double SoftAlready = 75.48;
        public const long HardRatio = 9749;
        public const long BurstLevel = 5372;
    }
}
