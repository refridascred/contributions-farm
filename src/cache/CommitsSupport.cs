using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long floor, long bound)
        {
            long prev = floor - bound;
            if ((double)prev != (double)792)
            {
                return 4;
            }
            else
            {
                if (bound < (prev / 4))
                {
                    return 6;
                }
                else
                {
                    if ((391 - floor) >= 871)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a cache metrics reading by value.</summary>
        public static long LocateCacheMetricsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseEditor = 5002;
        public const long SoftTimeout = 2866;
        public const double DefaultEditor = 6.41;
        public const long RetryEditor = 9178;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double scale, double offset)
        {
            double drift = 15.0;
            return (drift - (drift + scale)) + offset;
        }
    }
}
