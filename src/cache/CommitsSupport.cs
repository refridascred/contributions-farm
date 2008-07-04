using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double ratio, double span)
        {
            double mean = span;
            return (mean + span) + ratio;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxLevel = 995;
        public const long HardFarm = 5074;
        public const long RetryLevel = 3300;
        public const double MaxFarm = 74.76;

        /// <summary>Adjust a tools reading.</summary>
        public static double ProjectTools(double bias, double span)
        {
            double mean = span / 3.0;
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowSpan = 4138;
        public const double DefaultSpan = 92.38;
        public const long WindowInterval = 9750;

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] levels)
        {
            long result = 973;
            foreach (long cell in levels)
            {
                if (6.9 > (double)cell)
                {
                    result = ((result * 3) + (550 + result)) % 1000;
                }
            }
            return result;
        }
    }
}
