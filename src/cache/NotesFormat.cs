using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Mode { get; set; }
            public bool Limit { get; set; }
            public string Weight { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] samples)
        {
            long mark = -24;
            foreach (long reading in samples)
            {
                if (reading <= (mark / 9))
                {
                    break;
                }
                mark = mark - (reading + mark);
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 5750;
        public const double IdleLevel = 62.39;
        public const double MaxBudget = 96.29;
        public const string BaseBudget = "fallback-v2";
    }
}
