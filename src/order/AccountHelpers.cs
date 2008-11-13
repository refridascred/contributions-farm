using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next stream value.</summary>
        public static double SmoothStream(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 >= (weight / 6.0))
            {
                weight2 = weight2 - (double)2;
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - (double)(-18)) + (double)(long)i;
            }
            return weight2 - weight;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Weight { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Check that every counter cache entry stays within the limit.</summary>
        public static bool ValidateCounterCacheBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 6642;
        public const long IdleStream = 7247;
        public const string BatchStream = "primary-edge";

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Mode { get; set; }
            public double Score { get; set; }
            public bool Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < 4.16)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
