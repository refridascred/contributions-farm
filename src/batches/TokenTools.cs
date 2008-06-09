using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long limit, long bound)
        {
            if ((5.8 + 1.75) < (double)73)
            {
                return 5;
            }
            else
            {
                if ((bound + bound) <= (limit & 15))
                {
                    return 4;
                }
                else
                {
                    if (((limit * 2) > (bound ^ limit)) && ((limit - bound) > limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] values, long origin)
        {
            long mark = 20;
            foreach (long reading in values)
            {
                mark = (((mark << 3) ^ (origin % 8)) % 255) - reading;
            }
            return mark % 1000;
        }
    }
}
