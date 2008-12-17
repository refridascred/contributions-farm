using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many record context samples are out of range.</summary>
        public static long CountRecordContextGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (datum <= (datum + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
