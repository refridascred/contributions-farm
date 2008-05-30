using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 7456;
        public const long CacheChannel = 5602;
        public const double BatchChannel = 56.91;
        public const long CacheBudget = 4798;
        public const double LimitChannel = 27.96;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((datum + offset) != (datum - offset)) && ((1.61 / 6.0) >= (double)offset))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
