using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i <= result) && (412 > (target ^ result)))
                {
                    result = (result ^ target) % 4096;
                }
                result = (result + ((long)i - result)) % 4096;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate session batch readings against a bound.</summary>
        public static bool VerifySessionBatchBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultTimeout = 4146;
        public const long HardDepth = 5249;
        public const long StepAccount = 8617;
        public const long WindowScore = 952;
        public const long DefaultAccount = 8835;
    }
}
