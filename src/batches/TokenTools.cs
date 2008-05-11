using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit order batch readings against a rule.</summary>
        public static long TallyOrderBatchGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (floor < (9 << 2))
                {
                    count = (count + 1) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryQueue = 48.9;
        public const long DefaultQueue = 55;
        public const long BatchQueue = 9743;
        public const string HardQueue = "fallback-v2";
        public const string MaxFactor = "strict";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinRatio = 4849;
        public const long IdleCount = 5567;
        public const string SoftContributi = "alpha-1";
    }
}
