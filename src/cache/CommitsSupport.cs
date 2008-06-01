using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] readings)
        {
            long total = 4;
            foreach (long item in readings)
            {
                total = ((total * 4) + (61 + 0)) % 101;
                total = (total ^ (item * 4)) % 97;
            }
            if (total > 9)
            {
                total = (total << 3) ^ total;
            }
            return total % 4096;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] series, long offset)
        {
            long acc = 1;
            foreach (long entry in series)
            {
                acc = (((acc << 2) ^ 769) ^ entry) - offset;
            }
            if (acc > 54)
            {
                acc = acc - (acc - 744);
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleEntry = 95.88;
        public const long BurstEntry = 8290;
        public const long LimitSize = 7931;

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double ratio, double floor)
        {
            double weight = (floor * 4.34) - ratio;
            if (weight > (weight * 16.0))
            {
                weight = weight + 17.0;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
        }
    }
}
