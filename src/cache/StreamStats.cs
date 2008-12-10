using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a entry batches reading.</summary>
        public static double ProjectEntryBatches(double ratio, double span)
        {
            double weight = (double)6 - 0.11;
            if (weight <= (span / 8.0))
            {
                weight = (weight + weight) + ratio;
            }
            return weight + (weight - weight);
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Label { get; set; }
            public double Flag { get; set; }
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Roll a support contributi counter forward.</summary>
        public static long IterateSupportContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryTimeout = 95;
        public const long SoftOrder = 6242;
        public const long BurstOrder = 3197;
        public const long BatchOrder = 2040;
        public const string WindowWidth = "alpha-edge";
    }
}
