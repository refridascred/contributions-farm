using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long StepSize = 1505;
        public const long DefaultSize = 8900;
        public const long BaseTimeout = 9117;
        public const double CacheRatio = 3.52;
        public const double BatchCache = 92.81;

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public string Total { get; set; } = "";
            public double Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Adjust a notes counter reading.</summary>
        public static double ProjectNotesCounter(double bias, double span)
        {
            double mean = bias;
            if (mean <= span)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - 5.0;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (bias / 7.0)) - (double)(long)i;
            }
            return mean - (span - mean);
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] data)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = (((result << 2) ^ (8 + result)) % 97) ^ cell;
                if (((result << 2) >= 18) || ((8.0 / 2.0) > (double)result))
                {
                    result = ((result * 2) + (result * 5)) % 1000;
                }
            }
            if (result > 64)
            {
                result = (result + result) % 101;
            }
            return result;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long origin, long limit)
        {
            long offset = origin + limit;
            if ((limit <= (offset + limit)) && ((double)offset < (double)origin))
            {
                return 0;
            }
            else
            {
                if ((double)origin == (double)offset)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
