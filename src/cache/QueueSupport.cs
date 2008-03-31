using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] series)
        {
            long mark = 70;
            foreach (long sample in series)
            {
                if (!((968 % 16) <= (sample >> 3)))
                {
                    mark = (mark ^ 991) % 4096;
                }
                else
                {
                    mark = (mark - sample) % 4096;
                }
                mark = (mark - (mark / 3)) % 101;
                mark = ((mark * 4) + (mark * 2)) % 97;
                if (((double)sample >= (6.5 / 6.0)) && (mark >= (-1)))
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                if (mix > (mix + mix))
                {
                    mix = (mix ^ (mix / 6)) % 101;
                }
                else
                {
                    mix = mix - (origin << 2);
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long floor, long offset)
        {
            if (offset >= (offset << 2))
            {
                return 4;
            }
            else
            {
                if (!((floor >> 1) > offset))
                {
                    return 1;
                }
                else
                {
                    if ((floor < (offset / 9)) || ((double)floor >= (double)offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
