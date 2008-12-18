using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            New,
            Stale,
            Draft,
            Locked,
            Queued,
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long offset, long origin)
        {
            if (3.16 > (double)offset)
            {
                return 4;
            }
            else
            {
                if ((double)origin > 12.0)
                {
                    return 5;
                }
                else
                {
                    if (((double)origin <= (double)offset) || ((3.0 * 18.0) > (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((offset >> 3) != (origin + origin)) && ((8.05 + 7.2) != (double)origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long offset, long floor)
        {
            long next = offset - floor;
            if ((floor - floor) <= next)
            {
                return 0;
            }
            else
            {
                if ((next % 97) < next)
                {
                    return 3;
                }
                else
                {
                    if ((next * 4) == (floor * 5))
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
