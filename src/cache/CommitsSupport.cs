using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 13; i++)
            {
                result = (result << 3) ^ (limit + (long)i);
                for (int i3 = 0; i3 < 5; i3++)
                {
                    result = (result ^ ((long)i & 15)) + (long)i3;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
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
