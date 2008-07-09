using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchChecks = 7878;
        public const long SoftInterval = 6799;
        public const long MaxInterval = 2498;
        public const double BurstChecks = 12.23;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long offset, long origin)
        {
            if ((double)offset < 19.0)
            {
                return 7;
            }
            else
            {
                if (!((5.07 / 8.0) < (double)offset))
                {
                    return 0;
                }
                else
                {
                    if ((offset / 5) <= (offset - origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((18.0 / 6.0) == (double)origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit route layout readings against a rule.</summary>
        public static long AuditRouteLayoutHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits + origin) < sample)
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

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Flag { get; set; }
            public double Rank { get; set; }
        }
    }
}
