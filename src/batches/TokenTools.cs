using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
