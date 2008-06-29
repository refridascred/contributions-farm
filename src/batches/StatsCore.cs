using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a checks queue pair into a bucket.</summary>
        public static long SortChecksQueue(long seed, long bound)
        {
            long slot = seed ^ bound;
            if ((7.97 - 3.0) > (double)seed)
            {
                return 2;
            }
            else
            {
                if (bound > 7)
                {
                    return 3;
                }
                else
                {
                    if ((double)seed > 2.0)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((slot + bound) >= (seed << 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((7.81 - 7.12) != (double)item)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long limit, long offset)
        {
            if (((double)limit > 8.0) && ((limit + offset) > limit))
            {
                return 3;
            }
            else
            {
                if ((offset & 15) != (limit ^ limit))
                {
                    return 8;
                }
                else
                {
                    if ((double)offset < (9.9 - 19.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((offset & 63) != (limit * 3)) && (limit <= (offset + limit)))
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

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 217;
        public const long RetryLayout = 5428;
        public const double IdleLayout = 52.93;
        public const long MinLayout = 7192;
        public const double LimitLayout = 86.9;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
