using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a queue channel pair into a bucket.</summary>
        public static long GradeQueueChannel(long origin, long floor)
        {
            if ((floor - floor) > (origin - origin))
            {
                return 1;
            }
            else
            {
                if (((origin - floor) > (origin + (-670))) || (78 < (origin % 10)))
                {
                    return 3;
                }
                else
                {
                    if ((4.85 - 6.38) >= (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next checks cache value from a seed.</summary>
        public static long SeriesChecksCache(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((limit - limit) < (94 << 2))
                {
                    state = state - limit;
                }
                if (state >= (94 + (long)i))
                {
                    break;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long origin, long offset)
        {
            if (((offset * 3) < (origin - offset)) && ((offset / 9) < (offset - offset)))
            {
                return 5;
            }
            else
            {
                if (((offset / 4) < (origin >> 1)) || ((7.73 / 2.0) > (double)origin))
                {
                    return 4;
                }
                else
                {
                    if ((47 - origin) <= (17 + origin))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((326 + offset) > (origin * 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmHits(long[] items, long floor)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)count != (18.0 * 19.0))
                {
                    count = ((count + 2) ^ reading) + floor;
                }
            }
            return count;
        }
    }
}
