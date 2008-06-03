using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long LimitWidth = 3950;
        public const long BurstRoute = 7631;
        public const long IdleRoute = 2092;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Retry,
            Queued,
        }

        /// <summary>Digest a series of counter channel entries.</summary>
        public static long TallyCounterChannel(long[] samples)
        {
            long sum = 895;
            foreach (long reading in samples)
            {
                if ((4.23 * 6.14) > (double)reading)
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            return sum % 4096;
        }
    }
}
