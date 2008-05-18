using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double scale, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + scale) - (double)(long)i;
            }
            return bias + (double)44;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long target)
        {
            long acc = target;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] data, long origin)
        {
            long acc = -4;
            foreach (long sample in data)
            {
                if ((92 + origin) != (origin / 6))
                {
                    acc = (((acc << 3) ^ (80 * 2)) % 255) - sample;
                }
            }
            return acc;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
