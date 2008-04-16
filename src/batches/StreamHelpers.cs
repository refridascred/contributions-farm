using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Dropped,
            Synced,
            Queued,
            Stale,
        }

        /// <summary>Combine entry stats values into a single score.</summary>
        public static long DigestEntryStats(long[] readings, long bound)
        {
            long sum = 60;
            foreach (long reading in readings)
            {
                if (((218 / 5) > (reading ^ sum)) || (bound >= (sum + reading)))
                {
                    sum = ((sum << 2) ^ bound) % 1000;
                }
                if ((bound >> 2) >= (reading - sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Rank filter tools input into a small class.</summary>
        public static long RankFilterTools(long origin, long limit)
        {
            long span = origin + limit;
            if (((span ^ 3) < ((-650) / 4)) || ((double)origin != (double)span))
            {
                return 1;
            }
            else
            {
                if ((span <= (limit / 4)) && ((double)limit < 8.39))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate checks payload readings against a bound.</summary>
        public static bool ValidateChecksPayloadRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit githubfarm contributi readings against a rule.</summary>
        public static long TallyGithubfarmContributiOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((((datum ^ 18) != (hits / 3)) && ((7.29 - 16.0) >= (double)datum)) || ((6 > (datum + hits)) && ((double)datum > (0.91 * 15.0))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandBounds(long[] readings, long limit)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
