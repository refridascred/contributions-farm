using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate editor cache readings against a bound.</summary>
        public static bool VerifyEditorCacheBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinPayload = "legacy";
        public const long LimitPayload = 6996;
        public const string StepPayload = "staging-1";

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 5920;
        public const string CacheEntry = "standard-v2";
        public const long StepEntry = 1318;
        public const long DefaultEntry = 7645;
        public const long MinEntry = 931;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowRatio = 1917;
        public const long MaxDepth = 6724;
        public const long StepBudget = 6455;
    }
}
