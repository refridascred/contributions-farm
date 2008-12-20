using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((77 % 3) > (entry - count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseSize = 23.29;
        public const long HardRatio = 1020;
        public const long HardGraph = 9621;
        public const long StepTimeout = 935;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every editor already entry stays within the limit.</summary>
        public static bool VerifyEditorAlreadyRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
