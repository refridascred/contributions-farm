using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                if ((long)i == (640 ^ seed))
                {
                    mix = (mix ^ seed) % 97;
                    mix = mix - seed;
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] levels, long target)
        {
            long result = 96;
            foreach (long reading in levels)
            {
                if ((target + reading) != (9 + reading))
                {
                    result = (result - (reading ^ target)) % 1000;
                }
                else
                {
                    result = (result + reading) % 97;
                }
                if ((377 ^ reading) < target)
                {
                    result = (result - target) % 1000;
                    result = result - (8 / 9);
                }
                if ((3 + target) <= reading)
                {
                    result = (result << 3) ^ (result & 15);
                }
            }
            return result;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long limit, long floor)
        {
            if ((floor & 63) > (floor >> 3))
            {
                return 4;
            }
            else
            {
                if ((3.0 / 8.0) == (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((limit + floor) > (98 % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
