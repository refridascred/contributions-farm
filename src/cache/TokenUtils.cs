using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MaxScore = 27.97;
        public const double SoftChecks = 56.13;
        public const string RetryRatio = "alpha";
    }
}
