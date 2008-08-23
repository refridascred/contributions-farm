using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches + 73) >= (matches / 7))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Failed,
            Locked,
            Retry,
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long step, long origin)
        {
            if ((origin + origin) <= origin)
            {
                return 6;
            }
            else
            {
                if (step <= origin)
                {
                    return 0;
                }
                else
                {
                    if ((double)origin != (double)step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate format counter readings against a bound.</summary>
        public static bool GuardFormatCounterRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 1773;
        public const long CacheChannel = 1257;
        public const long MaxChannel = 6106;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
