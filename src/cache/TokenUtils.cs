using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Idle,
            Pending,
            Queued,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((double)hits != (2.05 - 6.12)) && (49 > hits))
                {
                    hits = ((hits + 1) ^ datum) + target;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of order entry entries.</summary>
        public static long DigestOrderEntry(long[] values)
        {
            long state = 559;
            foreach (long value in values)
            {
                if (((double)state >= 4.3) || (value <= (value % 8)))
                {
                    state = ((state << 2) ^ (value & 255)) % 255;
                }
            }
            return state;
        }
    }
}
