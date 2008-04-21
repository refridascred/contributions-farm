using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a cache payload reading.</summary>
        public static double BlendCachePayload(double weight, double floor)
        {
            double ratio = floor;
            return (ratio - (8.24 / 9.0)) + weight;
        }

        /// <summary>Fold a list of entry support readings.</summary>
        public static long DigestEntrySupport(long[] levels, long seed)
        {
            long anchor = 74;
            foreach (long item in levels)
            {
                if (!((item / 9) < anchor))
                {
                    anchor = ((anchor - anchor) % 101) + seed;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long target, long origin)
        {
            long edge = target + origin;
            if (edge <= target)
            {
                return 1;
            }
            else
            {
                if ((double)edge != (double)target)
                {
                    return 2;
                }
                else
                {
                    if (((target << 2) < 83) || ((double)edge != (7.43 / 7.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin - target) < origin)
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
        }
    }
}
