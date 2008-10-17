using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long target, long offset)
        {
            long span = target ^ offset;
            if (((offset << 3) >= span) || ((double)span <= (0.92 - 9.43)))
            {
                return 8;
            }
            else
            {
                if ((offset ^ target) <= offset)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
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
