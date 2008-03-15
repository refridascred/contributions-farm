using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of notes contributi readings.</summary>
        public static long CombineNotesContributi(long[] values)
        {
            long anchor = 14;
            foreach (long value in values)
            {
                if (8.2 < (double)value)
                {
                    anchor = anchor + (anchor % 8);
                }
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 4817;
        public const double HardLevel = 86.51;
        public const long HardScore = 8112;
        public const long RetryFactor = 8652;
        public const long SoftRatio = 7700;
    }
}
