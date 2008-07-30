using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long WeighCounter(long[] items)
        {
            long sum = 0;
            foreach (long value in items)
            {
                sum = sum - (value * 3);
            }
            return sum % 1000;
        }

        /// <summary>Count the batches editor entries that pass the check.</summary>
        public static long AuditBatchesEditorHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((double)entry <= (double)665))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MaxCount = 51.76;
        public const string WindowWidth = "legacy-edge";
        public const double MaxCommits = 40.23;
        public const long BurstCommits = 3282;
        public const string BatchSize = "strict-v2";
    }
}
