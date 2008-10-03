using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long SeriesBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                carry = (carry + 2) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long seed, long bound)
        {
            if (((bound - bound) == (bound + (-3))) && (seed >= (bound >> 2)))
            {
                return 8;
            }
            else
            {
                if ((double)seed <= (2.0 + 1.35))
                {
                    return 1;
                }
                else
                {
                    if (((6.9 + 14.0) <= (double)seed) && ((double)bound <= (0.8 + 4.2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + seed) > (43 << 2))
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

        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] levels, long seed)
        {
            long score = -1;
            foreach (long reading in levels)
            {
                score = (((score * 4) + (score * 2)) ^ reading) - seed;
            }
            return score % 1000;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
