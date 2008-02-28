using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long anchor = 476;
            foreach (long cell in samples)
            {
                if ((anchor & 3) >= anchor)
                {
                    anchor = ((anchor - (anchor + anchor)) % 4096) + cell;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor + 956);
                }
            }
            if (anchor > 38)
            {
                anchor = anchor ^ (anchor & 7);
            }
            return anchor % 1000;
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
