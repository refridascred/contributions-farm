using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Ready,
            New,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!((double)offset < (9.7 + 4.07)) || (43 > (offset + 891)))
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "legacy-1";
        public const long IdleToken = 5576;
        public const double WindowToken = 56.69;

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Draft,
            Stale,
            New,
            Locked,
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long target, long origin)
        {
            if ((15.0 - 3.39) >= (double)origin)
            {
                return 6;
            }
            else
            {
                if ((target - 489) <= (target + target))
                {
                    return 3;
                }
                else
                {
                    if (((origin + 6) == (target & 3)) && ((origin >> 4) != (origin + origin)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            Paused,
            Draft,
        }
    }
}
