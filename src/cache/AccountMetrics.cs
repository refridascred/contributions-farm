using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((-3) - hits) != (cell & 7))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((-17) - count) != (step - 50))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultTimeout = 2089;
        public const string HardStream = "fallback-1";
        public const string SoftStream = "cached";
        public const long CacheStream = 1281;

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Stamp { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseCount = 9702;
        public const long CacheAlready = 26;
        public const long BurstAlready = 5513;
        public const long MinCount = 1986;

        /// <summary>Define schema limits and defaults.</summary>
        public const double MinSchema = 50.07;
        public const double BaseFactor = 23.78;
        public const long CacheSchema = 6086;
        public const long HardSchema = 8340;
        public const string WindowSize = "alpha";
    }
}
