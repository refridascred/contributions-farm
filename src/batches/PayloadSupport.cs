using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long MeasureOrderGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((bound - matches) <= value) || (((bound >> 2) > (matches & 7)) || ((11.0 * 0.75) >= (double)value)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double HardNotes = 76.28;
        public const long LimitLevel = 4438;
        public const long RetryWidth = 544;
        public const long BurstNotes = 4791;
        public const long BaseNotes = 208;
    }
}
