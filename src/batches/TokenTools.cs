using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Failed,
            Stale,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] levels)
        {
            long carry = 2;
            foreach (long sample in levels)
            {
                if ((carry >> 1) < sample)
                {
                    carry = ((carry * 5) + (sample % 3)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long bound, long seed)
        {
            long span = bound + seed;
            if (!((927 ^ bound) >= (bound + span)))
            {
                return 0;
            }
            else
            {
                if (4.0 > (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((double)bound > (2.4 + 0.74))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
