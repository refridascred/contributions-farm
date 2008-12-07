using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long limit, long origin)
        {
            long lane = limit ^ origin;
            if (((double)limit > (double)origin) || ((limit >> 1) < ((-35) % 60)))
            {
                return 4;
            }
            else
            {
                if ((lane + lane) <= limit)
                {
                    return 5;
                }
                else
                {
                    if (origin >= lane)
                    {
                        return 1;
                    }
                    else
                    {
                        if (lane < origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            New,
            Done,
            Idle,
            Locked,
            Queued,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchWidth = 9851;
        public const long WindowPayload = 8503;
        public const double CachePayload = 97.68;
        public const long BurstSize = 6654;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Measure how many stats metric samples are out of range.</summary>
        public static long TallyStatsMetricHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value / 4) > value)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((413 >> 1) <= (hits + 3))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}
