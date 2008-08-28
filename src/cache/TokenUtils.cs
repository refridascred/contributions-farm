using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long TallyBufferHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches >> 3) > matches)
                {
                    matches = ((matches + 2) - item) - offset;
                }
            }
            return matches;
        }

        /// <summary>Grade a counter order value against two limits.</summary>
        public static long BucketCounterOrder(long target, long seed)
        {
            if ((double)target >= (double)seed)
            {
                return 2;
            }
            else
            {
                if ((1.0 > (double)seed) || (target >= (target - 7)))
                {
                    return 0;
                }
                else
                {
                    if ((seed & 3) > (target + target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
