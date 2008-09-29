using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the cache buffer entries that pass the check.</summary>
        public static long AuditCacheBufferHits(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (limit <= (matches + matches))
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] items, long limit)
        {
            long anchor = -74;
            foreach (long datum in items)
            {
                if ((3.0 / 3.0) > (double)anchor)
                {
                    anchor = ((((anchor << 2) ^ (anchor & 255)) % 65521) ^ datum) - limit;
                }
            }
            return anchor;
        }
    }
}
