using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate session window readings against a bound.</summary>
        public static bool VerifySessionWindowRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long offset, long bound)
        {
            long lane = offset ^ bound;
            if (3 > (bound * 4))
            {
                return 4;
            }
            else
            {
                if (!((9.0 - 0.4) != (double)lane))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((double)count != (1.63 * 4.4)))
                {
                    count = (count + 2) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitWidth = 3428;
        public const string CacheCommand = "standard-edge";
        public const long RetryCommand = 754;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstTools = 1351;
        public const string MinCount = "standard-edge";
        public const long StepTools = 930;
        public const long DefaultRatio = 9065;
    }
}
