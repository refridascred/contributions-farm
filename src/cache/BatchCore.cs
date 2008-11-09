using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double RetryContext = 46.71;
        public const double CacheContext = 62.18;
        public const double SoftSpan = 57.87;
        public const long HardLevel = 5779;

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 7102;
        public const string HardSize = "standard-v2";
        public const long CacheFarm = 2898;
        public const double MaxSpan = 0.37;

        /// <summary>Check that every farm entry entry stays within the limit.</summary>
        public static bool VerifyFarmEntryLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a support entry counter forward.</summary>
        public static long StepSupportEntry(long target)
        {
            long acc = target;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
