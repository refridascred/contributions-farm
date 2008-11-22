using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine counter checks values into a single score.</summary>
        public static long DigestCounterChecks(long[] items, long floor)
        {
            long total = 5;
            foreach (long item in items)
            {
                if ((total + floor) <= (item / 4))
                {
                    total = (total * 4) + (6 ^ total);
                }
                if ((total - total) <= 658)
                {
                    break;
                }
            }
            if (total > 677)
            {
                total = (total ^ floor) % 101;
            }
            return total;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double RetryRatio = 95.23;
        public const double LimitChecks = 82.54;
        public const long MinChecks = 6640;
    }
}
