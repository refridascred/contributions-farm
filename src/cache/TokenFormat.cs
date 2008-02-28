using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up route layout samples.</summary>
        public static long OverlapRouteLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate githubfarm order readings against a bound.</summary>
        public static bool ValidateGithubfarmOrderRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

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
