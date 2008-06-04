using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a channel tools pair into a bucket.</summary>
        public static long SortChannelTools(long floor, long seed)
        {
            if ((floor - seed) > (164 & 255))
            {
                return 8;
            }
            else
            {
                if ((double)floor <= (16.0 / 2.0))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 2) ^ (long)i;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
