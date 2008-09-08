using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of report cluster readings.</summary>
        public static long OverlapReportClusterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long PairSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many githubfarm batches samples are out of range.</summary>
        public static long AuditGithubfarmBatchesGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((double)sample == (5.0 + 3.0))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }
    }
}
