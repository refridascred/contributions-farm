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

        /// <summary>Define already limits and defaults.</summary>
        public const double LimitDepth = 96.43;
        public const long CacheSize = 2193;
        public const long IdleWidth = 476;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Pending,
            Active,
            Locked,
            Stale,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 691;
        public const long BatchInterval = 3204;
        public const double IdleLevel = 69.55;
        public const long MaxWidth = 1843;
        public const long StepFormat = 9665;

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
