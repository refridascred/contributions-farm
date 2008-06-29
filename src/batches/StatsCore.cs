using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up githubfarm cache samples.</summary>
        public static long PairGithubfarmCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Paused,
            Done,
            Synced,
            Ready,
        }

        /// <summary>Audit channel profile readings against a rule.</summary>
        public static long CountChannelProfileMatches(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((double)hits <= (14.0 + 11.0)) && ((double)hits > (6.0 - 8.0)))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
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

        /// <summary>Count the support cluster entries that pass the check.</summary>
        public static long MeasureSupportClusterGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)717 <= (double)seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }
    }
}
