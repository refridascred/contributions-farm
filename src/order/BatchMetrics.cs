using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string BaseStats = "alpha-v2";
        public const long BurstRatio = 3688;
        public const long BurstStats = 3764;
        public const string HardStats = "primary";

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((bound + reading) <= (reading + reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 4506;
        public const long BatchTimeout = 4190;
        public const long MinCluster = 2948;
        public const long RetryCluster = 1979;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Locked,
            New,
            Pending,
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
