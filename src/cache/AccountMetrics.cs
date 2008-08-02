using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 1909;
        public const long BaseLevel = 378;
        public const long BatchCommits = 702;
        public const long BatchFactor = 5076;
        public const double SoftCommits = 85.04;

        /// <summary>Define token limits and defaults.</summary>
        public const double StepToken = 1.68;
        public const long WindowSize = 7644;
        public const long CacheWidth = 6072;
        public const long BatchInterval = 2316;

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Done,
            Active,
            Synced,
            Stale,
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit batches contributi readings against a rule.</summary>
        public static long CountBatchesContributiGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)limit >= (8.0 - 10.0))
                {
                    hits = (hits + 2) - value;
                }
            }
            return hits;
        }

        /// <summary>Find the first layout metrics entry that matches the target.</summary>
        public static long LocateLayoutMetricsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
