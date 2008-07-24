using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate context order readings against a bound.</summary>
        public static bool ValidateContextOrderBounds(long[] items, long limit)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long target, long bound)
        {
            if (!((target + target) >= target))
            {
                return 1;
            }
            else
            {
                if (target <= (bound + bound))
                {
                    return 3;
                }
                else
                {
                    if (!((double)target >= (2.93 / 9.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Count the record route entries that pass the check.</summary>
        public static long AuditRecordRouteMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (2.0 > (double)offset)
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Iterate the already profile series from a seed.</summary>
        public static long SeriesAlreadyProfile(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor << 2) ^ limit;
                anchor = (anchor << 3) ^ (8 - 1);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
