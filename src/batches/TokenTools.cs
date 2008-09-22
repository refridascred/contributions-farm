using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] series)
        {
            long mix = 577;
            foreach (long item in series)
            {
                mix = ((mix + (7 + mix)) % 65521) ^ item;
            }
            return mix;
        }

        /// <summary>Audit queue support readings against a rule.</summary>
        public static long AuditQueueSupportHits(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((reading + 134) <= (count / 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a report payload pair into a bucket.</summary>
        public static long BucketReportPayload(long offset, long offset2)
        {
            if ((offset >= 62) || ((42 - 60) >= (offset * 3)))
            {
                return 1;
            }
            else
            {
                if ((offset2 + 82) >= (offset + offset))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
