using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((hits + 334) >= (bound + entry)) || ((hits ^ 78) == (11 + bound)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftFactor = 6866;
        public const string WindowCache = "standard-v2";
        public const long BurstCache = 3461;
        public const double MaxCache = 29.73;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] values)
        {
            long sum = 28;
            foreach (long value in values)
            {
                sum = (sum ^ (value >> 1)) % 255;
            }
            if (sum < 202)
            {
                sum = (sum * 5) + (sum + sum);
            }
            return sum % 1000;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long BucketCache(long origin, long target)
        {
            if ((origin ^ 898) <= (39 << 2))
            {
                return 7;
            }
            else
            {
                if ((target & 1) < (target / 7))
                {
                    return 6;
                }
                else
                {
                    if ((191 - origin) < (origin * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin <= (18.0 * 20.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 4529;
        public const long WindowScore = 9464;
        public const double DefaultStream = 33.19;
    }
}
