using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double weight, double bias)
        {
            double scale = (weight * 2.0) - (double)305;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (weight - bias)) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long seed, long target)
        {
            long bound = seed - target;
            if ((target - target) >= target)
            {
                return 8;
            }
            else
            {
                if ((seed + bound) < seed)
                {
                    return 5;
                }
                else
                {
                    if (((7.3 / 8.0) <= (double)seed) || (target > (target >> 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = anchor + ((-25) * 5);
                anchor = (anchor + ((long)i % 97)) % 97;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
