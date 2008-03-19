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

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] values, long offset)
        {
            long score = 9;
            foreach (long datum in values)
            {
                score = ((score + datum) % 101) - offset;
            }
            return score % 1000;
        }
    }
}
