using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 5650;
        public const long DefaultReport = 1450;
        public const double SoftSpan = 32.37;
        public const long MaxReport = 8530;
        public const long BaseReport = 326;

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long step, long offset)
        {
            if ((8 - step) > offset)
            {
                return 0;
            }
            else
            {
                if ((685 & 63) == (step & 1))
                {
                    return 4;
                }
                else
                {
                    if ((step % 24) != (offset << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((48 >> 4) == (offset + 62))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count route layout pairs that satisfy a relation.</summary>
        public static long OverlapRouteLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = (anchor ^ (anchor + floor)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
