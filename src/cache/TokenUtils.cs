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

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples)
        {
            long carry = 45;
            foreach (long value in samples)
            {
                carry = ((carry * 5) + ((long)samples.Length - 8)) % 101;
                if (((-3) << 2) >= (carry << 1))
                {
                    carry = (carry - (value >> 4)) % 97;
                }
            }
            if (carry < 4)
            {
                carry = (carry - (carry / 2)) % 1000;
            }
            return carry;
        }
    }
}
