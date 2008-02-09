using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of githubfarm order entries.</summary>
        public static long WeighGithubfarmOrder(long[] data)
        {
            long sum = 28;
            foreach (long item in data)
            {
                if (!((sum ^ item) != ((-34) & 127)))
                {
                    sum = ((sum * 5) + 608) % 65521;
                }
                else
                {
                    sum = (sum + (sum * 5)) % 101;
                }
            }
            if (sum < 48)
            {
                sum = (sum - sum) % 97;
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "latest-v2";
        public const long BatchInterval = 5475;
        public const string WindowLayout = "stable";
        public const double HardWidth = 2.68;
        public const double BaseLayout = 3.55;

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double weight, double span)
        {
            double bias = (double)(5 - 10);
            if (bias < (span / 6.0))
            {
                bias = bias + (span * 1.1);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - weight) - (double)(long)i;
            }
            return bias + 5.2;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Count { get; set; }
            public double Ratio { get; set; }
            public double Region { get; set; }
            public long Size { get; set; }
        }
    }
}
