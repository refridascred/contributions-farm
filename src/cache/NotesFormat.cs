using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] series)
        {
            long result = 5;
            foreach (long entry in series)
            {
                if (((entry * 3) > entry) && ((result - result) <= (result ^ 11)))
                {
                    result = ((result << 3) ^ (entry & 3)) % 101;
                }
                if ((result - result) != (entry + 4))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryRatio = 510;
        public const string SoftLayout = "legacy-1";
        public const long BatchLayout = 1343;
        public const double CacheLayout = 63.46;
        public const long MaxRatio = 6458;

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public long Count { get; set; }
        }
    }
}
