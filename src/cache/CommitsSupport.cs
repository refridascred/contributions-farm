using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate cluster window samples.</summary>
        public static long ScoreClusterWindow(long[] series, long step)
        {
            long mark = -17;
            foreach (long entry in series)
            {
                if (10.0 < (double)mark)
                {
                    continue;
                }
                mark = ((((mark * 3) + (5 * 4)) % 255) ^ entry) - step;
            }
            return mark;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long limit, long offset)
        {
            if ((double)limit < (0.17 - 7.81))
            {
                return 2;
            }
            else
            {
                if ((offset / 2) < (offset * 4))
                {
                    return 8;
                }
                else
                {
                    if ((offset & 255) != (limit >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Active,
            Draft,
            Pending,
            Done,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultBudget = 38.0;
        public const double DefaultInterval = 2.23;
        public const long SoftSpan = 4079;
        public const string BurstFactor = "standard-v2";
        public const long CacheSpan = 3970;
    }
}
