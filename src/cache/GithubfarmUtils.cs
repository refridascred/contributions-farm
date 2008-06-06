using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long origin, long origin2)
        {
            long slot = origin - origin2;
            if ((slot ^ origin) > origin)
            {
                return 7;
            }
            else
            {
                if ((origin2 + slot) > slot)
                {
                    return 6;
                }
                else
                {
                    if ((double)slot < 1.14)
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every route context entry stays within the limit.</summary>
        public static bool VerifyRouteContextBounds(long[] readings, long target)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Retry,
            Locked,
            Synced,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((-20) >> 2) == (sample % 3))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }
    }
}
