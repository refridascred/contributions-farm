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

        /// <summary>Validate queue commits readings against a bound.</summary>
        public static bool ValidateQueueCommitsLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Locked,
            Synced,
        }
    }
}
