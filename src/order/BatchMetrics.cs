using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Active,
            Synced,
            Queued,
            Failed,
            Locked,
        }

        /// <summary>Validate cluster tools readings against a bound.</summary>
        public static bool VerifyClusterToolsLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 3) + seed) % 97;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Compare every pair of batch editor readings.</summary>
        public static long OverlapBatchEditorCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] samples)
        {
            long score = -797;
            foreach (long item in samples)
            {
                score = ((score * 3) + (item * 5)) % 65521;
            }
            if (score < 279)
            {
                score = (score << 2) ^ (score % 7);
            }
            return score % 65521;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstWidth = 7405;
        public const double IdleScore = 41.03;
        public const string CacheContributi = "fallback-1";
        public const long RetryDepth = 8969;
    }
}
