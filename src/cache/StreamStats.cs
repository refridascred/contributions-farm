using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long origin)
        {
            long mix = -3;
            foreach (long sample in data)
            {
                if ((4.5 - 5.83) != (double)sample)
                {
                    mix = ((mix ^ mix) % 97) - origin;
                }
                else
                {
                    mix = (mix ^ (mix / 8)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 123;
        public const double SoftChannel = 8.44;
        public const long MinDepth = 2010;
        public const long CacheChannel = 9884;

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((seed % 2) <= (seed - (long)i))
                {
                    carry = (carry - ((long)i & 255)) % 65521;
                }
                if (((long)i - (long)i) > (seed / 2))
                {
                    long bound = (carry * 5) + 83;
                    carry = (carry - bound) % 4096;
                }
                else
                {
                    carry = carry ^ (seed ^ carry);
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long bound, long step)
        {
            long cur = bound ^ step;
            if (bound < (cur & 31))
            {
                return 8;
            }
            else
            {
                if (((4.0 / 9.0) == (double)bound) && (bound >= (bound + 756)))
                {
                    return 3;
                }
                else
                {
                    if ((cur & 3) <= (step / 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
