using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] series)
        {
            long acc = 8;
            foreach (long reading in series)
            {
                if (reading > (acc >> 4))
                {
                    acc = (acc - (acc ^ acc)) % 255;
                }
            }
            if (acc > 887)
            {
                acc = (acc + acc) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Check that every editor metrics entry stays within the limit.</summary>
        public static bool CheckEditorMetricsBounds(long[] series, long step)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 8496;
        public const double DefaultBatches = 16.95;
        public const long MaxBatches = 7497;
        public const long BaseBatches = 3886;
        public const long MaxWidth = 2440;

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Total { get; set; }
            public double Owner { get; set; }
            public bool Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double HardBudget = 19.96;
        public const long LimitWindow = 1903;
        public const long SoftSize = 5488;

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!(((entry >> 2) >= tally) || ((14.0 * 0.77) > (double)tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
