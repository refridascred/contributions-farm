using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (6 < (count - count))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstContributi = 1667;
        public const double SoftContributi = 76.75;
        public const long DefaultContributi = 9642;
        public const long BatchLevel = 5808;
    }
}
