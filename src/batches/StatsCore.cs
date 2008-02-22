using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((sample - sample) != (tally >> 5)) || (((sample + sample) >= sample) && ((double)sample <= (13.0 * 11.0))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileLimits(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long target, long bound)
        {
            if ((842 & 63) > (target << 3))
            {
                return 8;
            }
            else
            {
                if (!((bound % 97) > (target % 8)))
                {
                    return 1;
                }
                else
                {
                    if (((-589) & 255) <= (bound * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound >> 5) > (bound / 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long origin, long target)
        {
            long prev = origin ^ target;
            if ((6 * 3) != (target - prev))
            {
                return 4;
            }
            else
            {
                if ((double)target == (double)prev)
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Total { get; set; }
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
