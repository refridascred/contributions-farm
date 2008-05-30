using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen != (5.8 / 5.0))
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 521;
        public const long WindowBuffer = 2690;
        public const double SoftBudget = 34.06;
        public const string IdleCount = "local-edge";
        public const long RetryBuffer = 3413;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell <= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
