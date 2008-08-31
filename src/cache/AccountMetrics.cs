using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double weight, double span)
        {
            double scale = (double)(5 << 3);
            if (scale < span)
            {
                scale = scale + (span / 4.0);
            }
            else
            {
                scale = scale - (double)0;
            }
            return scale - (weight + scale);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BurstCounter = 9.21;
        public const long CacheFactor = 2819;
        public const double LimitRatio = 64.91;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Failed,
            Idle,
            New,
            Active,
        }

        /// <summary>Count entry layout pairs that satisfy a relation.</summary>
        public static long PairEntryLayoutCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double RetryToken = 39.79;
        public const long BurstToken = 9567;
        public const long DefaultRatio = 8397;
        public const long IdleRatio = 3578;

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] values, long seed)
        {
            long anchor = 4;
            foreach (long entry in values)
            {
                if (seed > (12 - seed))
                {
                    anchor = ((anchor << 3) ^ seed) - entry;
                }
            }
            if (anchor > 989)
            {
                anchor = (anchor * 4) + (seed - seed);
            }
            return anchor;
        }
    }
}
