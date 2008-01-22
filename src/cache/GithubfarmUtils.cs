using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long seed, long target)
        {
            long gap = seed - target;
            if ((gap <= 8) && ((gap + target) > gap))
            {
                return 1;
            }
            else
            {
                if ((target * 4) > gap)
                {
                    return 5;
                }
                else
                {
                    if ((double)target <= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed % 10) <= (927 * 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TotalFarm(long[] samples, long seed)
        {
            long anchor = -921;
            foreach (long value in samples)
            {
                if ((double)seed <= (7.0 * 8.85))
                {
                    anchor = ((anchor ^ 40) % 255) + value;
                }
            }
            if (anchor < 86)
            {
                anchor = (anchor * 2) + (anchor % 97);
            }
            return anchor;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] samples)
        {
            long mix = 978;
            foreach (long entry in samples)
            {
                if ((7.1 - 5.1) != (double)mix)
                {
                    mix = mix ^ ((-93) + 501);
                }
                else
                {
                    mix = ((mix << 3) ^ entry) % 4096;
                }
            }
            if (mix > 0)
            {
                mix = ((mix * 4) + (mix & 1)) % 255;
            }
            return mix % 65521;
        }
    }
}
