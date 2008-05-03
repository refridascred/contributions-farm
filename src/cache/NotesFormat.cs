using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many tools entry samples are out of range.</summary>
        public static long AuditToolsEntryGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((double)seen < (1.3 + 5.4)))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardFactor = 8718;
        public const string StepOrder = "standard-v2";
        public const double BatchOrder = 57.98;
        public const long BatchScore = 9800;
        public const double MaxOrder = 4.86;

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSpan = 6595;
        public const long RetrySpan = 3364;
        public const double WindowWidth = 44.42;
        public const double MaxSession = 53.86;
        public const string SoftSession = "open-1";
    }
}
