using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((seed * 4) < (seed + entry)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long target, long origin)
        {
            if ((target >> 1) > (target % 97))
            {
                return 1;
            }
            else
            {
                if ((origin - target) >= target)
                {
                    return 2;
                }
                else
                {
                    if ((target - target) == (origin + 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((origin ^ target) <= (origin * 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate stats queue readings against a bound.</summary>
        public static bool VerifyStatsQueueBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
