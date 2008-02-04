using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MinCache = "primary-v2";
        public const long BurstCache = 5364;
        public const long IdleTimeout = 6664;
        public const long RetryCache = 8972;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Weight { get; set; }
            public bool Region { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit editor profile readings against a rule.</summary>
        public static long AuditEditorProfileHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits % 16) != (7 + item))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((origin + seen) >= (origin >> 2))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] series, long bound)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
