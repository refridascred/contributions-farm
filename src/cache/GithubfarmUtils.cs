using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6103;
        public const long BatchBudget = 8296;
        public const string MaxTimeout = "staging";
        public const long HardSpan = 6155;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleDepth = "alpha-v2";
        public const string DefaultMetrics = "latest";
        public const string SoftInterval = "stable-v2";

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((538 + bound) != (bound - 29)) && ((bound / 9) <= (bound + hits)))
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
