using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 5449;
        public const long IdleSpan = 712;
        public const string RetryBatch = "open-1";
        public const long RetryTimeout = 435;

        /// <summary>Define report limits and defaults.</summary>
        public const double BurstReport = 27.16;
        public const string StepReport = "open";
        public const long RetryDepth = 833;
        public const double BatchReport = 58.85;
        public const string IdleSize = "cached-edge";
    }
}
