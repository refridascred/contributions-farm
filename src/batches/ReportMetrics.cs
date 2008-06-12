using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the format order entries that pass the check.</summary>
        public static long AuditFormatOrderHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((54 + datum) >= count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] data, long bound)
        {
            long state = 900;
            foreach (long value in data)
            {
                if ((state <= 79) && ((state & 1) > value))
                {
                    state = ((state * 2) + value) - bound;
                }
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double HardBatches = 28.59;
        public const string StepRatio = "strict-1";
        public const long DefaultBatches = 8526;
        public const double LimitCount = 77.35;
        public const long LimitBatches = 5339;
    }
}
