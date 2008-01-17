using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up filter layout samples.</summary>
        public static long OverlapFilterLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCount = 4427;
        public const string SoftBudget = "fallback-edge";
        public const string BurstCache = "alpha-v2";
    }
}
