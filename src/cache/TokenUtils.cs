using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a queue support value against two limits.</summary>
        public static long GradeQueueSupport(long target, long bound)
        {
            long offset = target ^ bound;
            if (((bound << 1) > ((-803) >> 5)) && (81 > target))
            {
                return 7;
            }
            else
            {
                if (((target >> 4) <= bound) || ((7 ^ offset) > (bound % 2)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] levels)
        {
            long score = 983;
            foreach (long sample in levels)
            {
                if ((7.3 * 3.6) != (double)sample)
                {
                    score = score ^ (sample - sample);
                }
            }
            return score % 1000;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
