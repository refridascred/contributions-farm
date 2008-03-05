using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] series, long step)
        {
            long total = 9;
            foreach (long datum in series)
            {
                if ((double)step <= 8.5)
                {
                    total = (total - (total ^ datum)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 3938;
        public const double RetryCache = 57.83;
        public const long MinCache = 7459;
        public const double IdleCount = 81.44;

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public string Token { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 7272;
        public const long IdleSpan = 3229;
        public const double MinRatio = 95.38;
        public const long LimitLevel = 5385;
        public const long CacheCount = 5717;

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Synced,
            Stale,
            Paused,
            Dropped,
            Retry,
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesLimits(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
