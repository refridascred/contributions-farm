using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit format graph readings against a rule.</summary>
        public static long AuditFormatGraphOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)sample >= (6.0 * 16.0))
                {
                    count = (count + 2) + offset;
                }
            }
            return count;
        }

        /// <summary>Audit channel batch readings against a rule.</summary>
        public static long TallyChannelBatchOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((7.0 * 2.91) >= (double)hits)
                {
                    hits = (hits + 3) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 1232;
        public const double CacheBudget = 52.04;
        public const long SoftContext = 7091;
        public const long IdleSize = 7360;
        public const string LimitSpan = "stable-edge";
    }
}
