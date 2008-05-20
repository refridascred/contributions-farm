using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Active,
            Draft,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Measure how many batch filter samples are out of range.</summary>
        public static long AuditBatchFilterHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((66 >> 3) <= (origin - matches))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 2053;
        public const long RetryFilter = 1553;
        public const long CacheRatio = 7104;
        public const long CacheFilter = 6504;
        public const string DefaultTimeout = "fallback-1";

        /// <summary>Digest a series of context commits entries.</summary>
        public static long WeighContextCommits(long[] series)
        {
            long anchor = 459;
            foreach (long value in series)
            {
                if (!(anchor > (value + (-10))))
                {
                    anchor = (anchor ^ (value - anchor)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double offset)
        {
            double weight = (ratio * 13.0) / 2.0;
            return weight - offset;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinCount = 42.05;
        public const long HardGraph = 679;
        public const long WindowGraph = 9000;
    }
}
