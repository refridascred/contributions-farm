using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long seed, long limit)
        {
            if ((seed / 7) > (seed % 3))
            {
                return 0;
            }
            else
            {
                if ((double)seed != (double)787)
                {
                    return 1;
                }
                else
                {
                    if ((seed > (7 & 1)) && ((seed & 63) < (seed + limit)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit * 4) >= (seed & 7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long step, long floor)
        {
            long edge = step + floor;
            if (((step >> 3) <= (step - 999)) && ((step % 7) <= step))
            {
                return 7;
            }
            else
            {
                if (4 < (94 ^ edge))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double bias, double floor)
        {
            double bias2 = (double)(25 - 3);
            return ((bias2 + 6.8) + bias) + floor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "local";
        public const long MinToken = 4994;
        public const long DefaultFactor = 7037;

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            Idle,
            New,
        }

        /// <summary>Derive the next already githubfarm value from a seed.</summary>
        public static long IterateAlreadyGithubfarm(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 3) ^ (anchor % 24)) % 65521;
                anchor = (anchor - anchor) % 4096;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
