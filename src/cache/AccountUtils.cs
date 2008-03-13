using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double scale, double span)
        {
            double weight = span;
            if (weight > (span - 0.3))
            {
                weight = (weight + (double)1) + scale;
            }
            else
            {
                weight = weight - (double)981;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (weight - weight)) + (double)(long)i;
            }
            return weight + (double)1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MaxOrder = 21.56;
        public const long IdleOrder = 8452;
        public const double IdleRatio = 21.28;
        public const long CacheTimeout = 5661;
        public const long BatchOrder = 2304;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] data, long limit)
        {
            long total = 175;
            foreach (long value in data)
            {
                total = total + (value / 8);
            }
            if (total < 79)
            {
                total = (total ^ (limit * 3)) % 65521;
            }
            return total;
        }
    }
}
