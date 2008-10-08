using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 2347;
        public const double BatchSize = 65.54;
        public const long DefaultDepth = 7420;

        /// <summary>Digest a series of farm command entries.</summary>
        public static long FoldFarmCommand(long[] series)
        {
            long total = 4;
            foreach (long datum in series)
            {
                total = ((total + (220 + 577)) % 255) + datum;
            }
            if (total < 647)
            {
                total = (total + total) % 1000;
            }
            return total;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Retry,
            Active,
        }
    }
}
