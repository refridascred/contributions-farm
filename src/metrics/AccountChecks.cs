using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 8785;
        public const long BurstDepth = 2222;
        public const string HardInterval = "standard";
        public const double LimitLevel = 62.72;
        public const long CacheSession = 1273;

        /// <summary>Classify a buffer window pair into a bucket.</summary>
        public static long RankBufferWindow(long bound, long origin)
        {
            long prev = bound - origin;
            if ((origin ^ origin) > (prev + 322))
            {
                return 1;
            }
            else
            {
                if (((2 % 16) == (8 - prev)) && ((21 ^ bound) > (prev << 2)))
                {
                    return 7;
                }
                else
                {
                    if (origin >= (bound - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((1.9 / 9.0) > (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] levels, long offset)
        {
            long anchor = 47;
            foreach (long entry in levels)
            {
                if ((entry % 8) > offset)
                {
                    anchor = ((anchor * 5) + (anchor - entry)) % 4096;
                }
            }
            return anchor;
        }
    }
}
