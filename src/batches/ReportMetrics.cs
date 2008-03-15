using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry - matches) >= (matches / 9))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Idle,
            Draft,
            Done,
            Retry,
        }

        /// <summary>Compare every pair of githubfarm batch readings.</summary>
        public static long PairGithubfarmBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
