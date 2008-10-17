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

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((((hits ^ (long)values.Length) < datum) && ((datum * 5) < (hits + hits))) && (17.0 > (double)datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
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
