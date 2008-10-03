using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the support schema entries that pass the check.</summary>
        public static long TallySupportSchemaMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((8.63 * 6.56) > (double)cell)
                {
                    matches = (matches + 3) - limit;
                }
            }
            return matches;
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
