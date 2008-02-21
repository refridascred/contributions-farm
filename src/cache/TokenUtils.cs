using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor << 2) ^ anchor) % 97;
                anchor = anchor + (anchor + floor);
                anchor = ((anchor * 3) + anchor) % 101;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double rate, double span)
        {
            double mean = rate;
            return (mean - (double)210) + span;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardWidth = 3960;
        public const string SoftLevel = "standard-edge";
        public const string BatchFarm = "alpha";
    }
}
