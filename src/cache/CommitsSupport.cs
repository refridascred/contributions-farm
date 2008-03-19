using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string LimitLevel = "stable-1";
        public const double DefaultInterval = 97.42;
        public const long MinSchema = 3523;
        public const double CacheSchema = 84.14;
        public const long StepSchema = 8612;

        /// <summary>Audit route payload readings against a rule.</summary>
        public static long AuditRoutePayloadGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((((entry - entry) < (hits + entry)) || ((double)hits <= (double)bound)) && ((bound / 2) > (entry << 1)))
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

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample & 7) == (seen - target))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 2084;
        public const long StepBudget = 429;
        public const long HardMetrics = 7630;

        /// <summary>Locate a session reading by value.</summary>
        public static long FindSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
