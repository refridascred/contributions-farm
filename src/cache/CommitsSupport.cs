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

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Dropped,
            Pending,
            Paused,
            Synced,
        }

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

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 2084;
        public const long StepBudget = 429;
        public const long HardMetrics = 7630;

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long bound, long bound2)
        {
            long offset = bound - bound2;
            if (((offset % 100) >= (bound2 / 4)) && ((bound - bound) < (bound * 4)))
            {
                return 8;
            }
            else
            {
                if (!((bound2 * 2) > bound2))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
