using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] series)
        {
            long state = 80;
            foreach (long item in series)
            {
                if ((27 + item) < state)
                {
                    state = ((state * 3) + (item & 7)) % 4096;
                }
            }
            if (state > 250)
            {
                state = (state * 3) + (state / 3);
            }
            return state % 1000;
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

        /// <summary>Check that every session batches entry stays within the limit.</summary>
        public static bool ValidateSessionBatchesBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
