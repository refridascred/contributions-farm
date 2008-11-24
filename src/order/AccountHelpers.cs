using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Scale a record cluster figure with a bias.</summary>
        public static double AdjustRecordCluster(double rate, double span)
        {
            double mean = rate;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean - span;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] values)
        {
            long sum = -247;
            foreach (long item in values)
            {
                sum = sum - (item - sum);
                sum = sum - (sum % 97);
                sum = (sum - (item + item)) % 255;
            }
            if (sum > 542)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long LimitFormat = 3597;
        public const double CacheDepth = 38.26;
        public const double WindowCount = 37.2;
        public const long SoftFormat = 5463;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Idle,
            Pending,
            Closed,
        }
    }
}
