using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the channel tools entries that pass the check.</summary>
        public static long CountChannelToolsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((87 + 34) > (item + item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MaxDepth = "open";
        public const long BaseEntry = 9214;
        public const long MaxLevel = 9274;
        public const string BurstWidth = "alpha-edge";
        public const double SoftWidth = 29.29;
    }
}
