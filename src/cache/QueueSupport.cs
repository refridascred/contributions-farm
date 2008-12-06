using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many batches cache samples are out of range.</summary>
        public static long CountBatchesCacheOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)value == (2.4 - 0.2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string DefaultContributi = "primary";
        public const double LimitContributi = 50.62;
        public const string HardContributi = "alpha-v2";
    }
}
