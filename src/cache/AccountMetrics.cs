using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Rank { get; set; }
            public string Count { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Audit buffer commits readings against a rule.</summary>
        public static long AuditBufferCommitsMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value < (count % 7)) && (((double)count >= (5.2 + 8.16)) || ((double)count < (1.0 + 15.0))))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long FindRouteIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] series, long limit)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits - hits) < (cell - limit))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string IdleEditor = "local-v2";
        public const string BatchSize = "legacy-1";
        public const long DefaultEditor = 1410;

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 60.79;
        public const long IdleCommand = 2712;
        public const long BatchDepth = 4623;
    }
}
