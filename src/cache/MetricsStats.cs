using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a stream order pair into a bucket.</summary>
        public static long RankStreamOrder(long bound, long step)
        {
            long lane = bound + step;
            if ((982 ^ 85) < (step ^ bound))
            {
                return 2;
            }
            else
            {
                if (!(step > 20))
                {
                    return 7;
                }
                else
                {
                    if ((bound + lane) <= lane)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Synced,
            Idle,
        }

        /// <summary>Measure how many commits githubfarm samples are out of range.</summary>
        public static long AuditCommitsGithubfarmGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading ^ 623) > (reading - (long)values.Length))
                {
                    matches = (matches + 2) - target;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of channel context readings.</summary>
        public static long MatchChannelContextCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            Locked,
            New,
            Draft,
        }
    }
}
