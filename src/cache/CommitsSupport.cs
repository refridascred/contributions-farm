using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double gain, double bias)
        {
            double weight = (bias / 4.0) / 6.0;
            if (weight < 7.9)
            {
                weight = (weight - bias) + gain;
            }
            else
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight + 0.1;
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

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double bias, double offset)
        {
            double load = offset;
            for (int i = 0; i < 5; i++)
            {
                load = ((load - offset) - (double)(long)i) - bias;
            }
            return load - 7.1;
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
