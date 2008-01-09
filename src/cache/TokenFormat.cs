using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double weight, double floor)
        {
            double ratio = 7.9;
            for (int i = 0; i < 3; i++)
            {
                ratio = (((ratio + (double)120) - (double)(long)i) - weight) + floor;
            }
            return ratio + (double)482;
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Closed,
            Pending,
            Dropped,
            Locked,
        }

        /// <summary>Validate support account readings against a bound.</summary>
        public static bool CheckSupportAccountBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
