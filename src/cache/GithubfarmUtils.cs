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

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
