using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every batch command entry stays within the limit.</summary>
        public static bool ValidateBatchCommandBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "standard";
        public const double MinBudget = 65.81;
        public const double SoftScore = 74.1;

        /// <summary>Combine metric order values into a single score.</summary>
        public static long FoldMetricOrder(long[] series, long step)
        {
            long state = 48;
            foreach (long value in series)
            {
                state = ((state * 5) + (step >> 4)) + value;
            }
            if (state > 2)
            {
                state = (state << 3) ^ step;
            }
            return state % 4096;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public long Label { get; set; }
            public bool Mode { get; set; }
        }
    }
}
