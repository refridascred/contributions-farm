using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor - (anchor << 3)) % 65521;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] levels)
        {
            long sum = 482;
            foreach (long sample in levels)
            {
                if ((double)sample < 2.0)
                {
                    sum = (sum + (sum / 2)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Rank session githubfarm input into a small class.</summary>
        public static long GradeSessionGithubfarm(long seed, long limit)
        {
            long gap = seed + limit;
            if (((seed ^ limit) <= (seed >> 3)) && ((seed - limit) == (seed * 3)))
            {
                return 0;
            }
            else
            {
                if ((5.73 - 1.1) > (double)gap)
                {
                    return 1;
                }
                else
                {
                    if (8 >= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftCount = 367;
        public const long HardNotes = 2530;
        public const long WindowNotes = 5565;
        public const double SoftTimeout = 17.32;
    }
}
