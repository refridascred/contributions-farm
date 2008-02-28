using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((9.0 * 2.0) == (double)matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string LimitLevel = "latest-v2";
        public const string SoftBatches = "staging-1";
        public const long CacheFactor = 2458;
        public const long DefaultBudget = 8408;
        public const string StepRatio = "legacy";

        /// <summary>Count the batch editor entries that pass the check.</summary>
        public static long AuditBatchEditorOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally + (long)items.Length) < (long)items.Length))
                {
                    tally = ((tally + 3) - sample) - step;
                }
            }
            return tally;
        }
    }
}
