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

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Ready,
            Synced,
            Paused,
            Draft,
            Stale,
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

        /// <summary>Check that every checks cache entry stays within the limit.</summary>
        public static bool GuardChecksCacheBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
