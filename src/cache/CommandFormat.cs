using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((tally >> 3) < (entry - tally)) || ((9 % 2) > (entry * 4)))
                {
                    tally = (tally + 1) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] data, long target)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitEditor = 74.01;
        public const long MaxSize = 9499;
        public const long SoftEditor = 5426;
        public const double BatchEditor = 77.64;

        /// <summary>Validate layout contributi readings against a bound.</summary>
        public static bool ValidateLayoutContributiBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
