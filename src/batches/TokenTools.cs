using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the session stream entries that pass the check.</summary>
        public static long CountSessionStreamGaps(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (350 >= reading)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading & 1) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 7799;
        public const double WindowMetric = 41.51;
        public const double MinMetric = 44.87;
        public const string BaseInterval = "local-edge";
        public const long SoftTimeout = 9119;
    }
}
