using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long target, long seed)
        {
            long edge = target ^ seed;
            if ((12.0 * 2.79) < (double)edge)
            {
                return 5;
            }
            else
            {
                if ((seed / 5) != (edge + 4))
                {
                    return 3;
                }
                else
                {
                    if (seed < 3)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((edge << 1) > (69 - seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a already cache reading.</summary>
        public static double SmoothAlreadyCache(double rate, double span)
        {
            double ratio = (span * 3.4) - rate;
            if (ratio < (double)8)
            {
                ratio = ratio - span;
            }
            else
            {
                ratio = ratio + (span + ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)53) - (double)(long)i;
            }
            return ratio + (rate + span);
        }

        /// <summary>Measure how many cache editor samples are out of range.</summary>
        public static long CountCacheEditorGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((5 <= reading) && ((18.0 * 2.3) <= (double)count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
