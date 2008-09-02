using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of already order entries.</summary>
        public static long CombineAlreadyOrder(long[] data)
        {
            long anchor = 263;
            foreach (long value in data)
            {
                anchor = (anchor + (value + value)) % 101;
            }
            return anchor;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 > (ratio * 6.9))
            {
                ratio2 = ratio2 + (ratio + span);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + (4.34 - ratio2)) + (double)(long)i;
            }
            return ratio2 + (8.9 * 7.14);
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((0.1 + 13.0) == (double)matches)
                {
                    matches = ((matches + 3) + cell) + target;
                }
            }
            return matches;
        }
    }
}
