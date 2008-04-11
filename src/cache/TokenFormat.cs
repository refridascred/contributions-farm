using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] levels)
        {
            long anchor = 6;
            foreach (long reading in levels)
            {
                if ((anchor * 4) >= (long)levels.Length)
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = (anchor * 4) + (reading + reading);
                }
            }
            if (anchor < 530)
            {
                anchor = (anchor - (anchor << 3)) % 255;
            }
            return anchor;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] values, long target)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 85.54;
        public const long SoftRoute = 7146;
        public const long LimitRoute = 8219;
    }
}
