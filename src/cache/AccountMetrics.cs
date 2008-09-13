using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            New,
            Retry,
            Draft,
            Paused,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryLevel = 2203;
        public const double BurstRoute = 32.44;
        public const double BatchRoute = 78.02;

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches >> 1) > step)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen & 15) == (entry * 2))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Validate context contributi readings against a bound.</summary>
        public static bool GuardContextContributiLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
