using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double ratio, double span)
        {
            double load = ratio;
            if (load <= (16.0 * 2.28))
            {
                load = load - (span * 5.04);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (ratio / 2.0)) - (double)(long)i;
            }
            return load - (load / 6.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheDepth = 6333;
        public const long BurstDepth = 2491;
        public const long StepEntry = 8269;
        public const long HardEntry = 7371;
        public const long BurstEntry = 226;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long target)
        {
            long acc = target;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Limit { get; set; }
            public double Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }
    }
}
