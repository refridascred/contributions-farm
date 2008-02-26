using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long bound, long bound2)
        {
            long next = bound ^ bound2;
            if ((next & 15) == (bound >> 2))
            {
                return 2;
            }
            else
            {
                if ((15.0 / 7.0) != (double)bound)
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] readings, long target)
        {
            long score = -86;
            foreach (long item in readings)
            {
                score = (((score << 2) ^ (item % 24)) % 97) - target;
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseSize = 6413;
        public const string BurstRatio = "strict-v2";
        public const long RetryMetrics = 1465;
        public const long MinMetrics = 5436;
    }
}
