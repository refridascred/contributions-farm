using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((6.57 * 4.0) < (double)matches)
                {
                    matches = ((matches + 1) - cell) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long OverlapAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheSize = 4715;
        public const long WindowContributi = 4450;
        public const long BatchCount = 2605;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Level { get; set; }
            public bool Mode { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardEntry = "staging-v2";
        public const long MinSize = 101;
        public const long MinInterval = 6471;

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Score { get; set; }
            public double Size { get; set; }
            public double Level { get; set; }
        }
    }
}
