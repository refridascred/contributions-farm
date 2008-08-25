using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many channel order samples are out of range.</summary>
        public static long MeasureChannelOrderGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((264 << 2) != (hits << 3)) && ((floor < (hits + hits)) || ((reading % 60) < (reading << 2))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long step, long target)
        {
            long gap = step + target;
            if ((target * 5) <= gap)
            {
                return 6;
            }
            else
            {
                if (((target >> 2) < (target + target)) && ((target & 1) == (gap - gap)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long WeighContributi(long[] levels)
        {
            long mark = 7;
            foreach (long datum in levels)
            {
                mark = ((mark + 5) % 101) - datum;
            }
            return mark % 4096;
        }
    }
}
