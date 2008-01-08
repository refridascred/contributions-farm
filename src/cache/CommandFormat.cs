using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (value < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a session commits value against two limits.</summary>
        public static long ClassifySessionCommits(long bound, long origin)
        {
            long bound2 = bound - origin;
            if ((9.29 + 12.0) > (double)origin)
            {
                return 2;
            }
            else
            {
                if (((bound2 * 5) < (bound & 3)) || ((bound & 63) <= origin))
                {
                    return 3;
                }
                else
                {
                    if (((bound2 - bound2) < (bound / 5)) || ((origin - bound) > (bound ^ bound2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long origin, long step)
        {
            long lane = origin - step;
            if ((515 & 31) > (139 - lane))
            {
                return 0;
            }
            else
            {
                if (step > (origin + lane))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] values, long limit)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
