using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] items)
        {
            long acc = 4;
            foreach (long value in items)
            {
                acc = ((acc + (acc >> 3)) % 255) + value;
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 8027;
        public const string BurstInterval = "primary-1";
        public const long SoftMetrics = 6029;
        public const double BurstTimeout = 76.01;

        /// <summary>Audit queue batches readings against a rule.</summary>
        public static long CountQueueBatchesOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!((entry ^ entry) <= (matches + 89)) || ((matches / 4) < (26 + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
