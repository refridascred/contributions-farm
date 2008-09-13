using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((double)reading == (8.0 * 19.0)) || ((double)reading < (20.0 * 0.8)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long BucketStats(long limit, long limit2)
        {
            if ((limit2 << 1) <= limit2)
            {
                return 1;
            }
            else
            {
                if ((2 ^ limit2) > 3)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
