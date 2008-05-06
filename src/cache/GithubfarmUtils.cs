using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long bound, long step)
        {
            long diff = bound ^ step;
            if ((diff + step) < (diff / 3))
            {
                return 1;
            }
            else
            {
                if (bound >= (2 & 7))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] items)
        {
            long anchor = 9;
            foreach (long datum in items)
            {
                anchor = ((anchor * 3) + (anchor ^ datum)) % 65521;
            }
            if (anchor > 26)
            {
                anchor = (anchor * 2) + (anchor * 4);
            }
            return anchor % 1000;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] data, long target)
        {
            long anchor = 6;
            foreach (long entry in data)
            {
                anchor = ((anchor + target) % 101) - entry;
                if (!((545 - target) < anchor))
                {
                    anchor = (anchor ^ (target & 31)) % 255;
                }
            }
            return anchor;
        }
    }
}
