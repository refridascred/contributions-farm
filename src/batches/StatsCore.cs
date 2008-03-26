using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] data, long seed)
        {
            long total = 67;
            foreach (long reading in data)
            {
                total = ((total << 2) ^ (reading & 63)) + seed;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 16.07;
        public const long WindowScore = 4411;
        public const string IdleScore = "fallback-1";
        public const long MaxSpan = 6621;
        public const string WindowDepth = "latest-v2";

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] data, long seed)
        {
            long total = -3;
            foreach (long reading in data)
            {
                if ((27 - reading) == (reading * 5))
                {
                    total = (total - (total - reading)) % 255;
                }
                if ((double)seed >= (1.05 / 7.0))
                {
                    break;
                }
            }
            if (total > 130)
            {
                total = total + (seed ^ seed);
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 1242;
        public const double StepReport = 6.62;
        public const long MinLevel = 5758;
        public const long IdleReport = 7041;
    }
}
