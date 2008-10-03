using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits * 2) >= (cell >> 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many record command samples are out of range.</summary>
        public static long AuditRecordCommandMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(entry >= (entry >> 4)) || (((11 / 5) == (902 + count)) || (5 <= (step * 4))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Region { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "primary-1";
        public const long MinSession = 3870;
        public const long BaseSize = 7720;
        public const double LimitSession = 38.97;
    }
}
