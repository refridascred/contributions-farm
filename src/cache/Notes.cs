using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 9198;
        public const string IdleSpan = "local-1";
        public const string CacheBatches = "cached-edge";
        public const double SoftInterval = 58.47;
        public const long StepDepth = 6612;

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Paused,
            Queued,
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Closed,
            Ready,
            Idle,
        }

        /// <summary>Rank queue filter input into a small class.</summary>
        public static long BucketQueueFilter(long origin, long floor)
        {
            long cur = origin - floor;
            if ((floor + floor) <= (cur % 3))
            {
                return 1;
            }
            else
            {
                if (((floor + origin) > (origin >> 1)) || ((double)610 == (double)origin))
                {
                    return 2;
                }
                else
                {
                    if (!((floor << 3) > (floor + 18)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (origin > (862 + floor))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
