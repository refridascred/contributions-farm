using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((((double)item >= (7.9 / 9.0)) && ((item + item) == (0 & 31))) && (item > (count >> 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepDepth = 7726;
        public const long IdleFactor = 663;
        public const string BatchEditor = "cached";
        public const string WindowEditor = "standard-1";

        /// <summary>Audit queue batches readings against a rule.</summary>
        public static long CountQueueBatchesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((entry ^ entry) <= (matches + 89)) || ((matches / 4) < (26 + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
