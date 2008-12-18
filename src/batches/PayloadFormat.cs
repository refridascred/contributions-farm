using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double load = weight;
            if (load <= weight)
            {
                load = (load + load) + offset;
            }
            return load - (weight / 4.0);
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] items)
        {
            long sum = 38;
            foreach (long item in items)
            {
                if (item >= (item / 7))
                {
                    sum = (sum - (12 ^ (-273))) % 255;
                }
                else
                {
                    sum = (sum - (item / 4)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinLevel = 28.44;
        public const long HardRatio = 6885;
        public const double MaxSize = 71.1;
        public const long BatchTimeout = 9062;
        public const long DefaultQueue = 6852;
    }
}
