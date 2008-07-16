using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long BucketBatch(long limit, long limit2)
        {
            if ((limit2 > (664 - limit2)) && ((limit2 & 63) >= (limit2 + limit)))
            {
                return 2;
            }
            else
            {
                if ((double)limit2 > (double)(-6))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen / 2) > seen)
                {
                    seen = ((seen + 3) ^ value) + bound;
                }
            }
            return seen;
        }
    }
}
