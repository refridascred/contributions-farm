using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MinScore = 98.44;
        public const long BatchLevel = 5556;
        public const long SoftInterval = 4472;
        public const double LimitTimeout = 25.21;

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((842 >> 2) <= (count >> 3))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
