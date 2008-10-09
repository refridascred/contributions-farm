using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "legacy";
        public const double SoftToken = 73.26;
        public const double RetryCount = 31.73;
        public const long StepToken = 241;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long step, long limit)
        {
            if (!((step + limit) > (587 + limit)))
            {
                return 0;
            }
            else
            {
                if ((step ^ 525) != (limit * 3))
                {
                    return 6;
                }
                else
                {
                    if (step >= (step + step))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((6 * 3) >= limit)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
