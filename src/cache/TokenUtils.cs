using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the batches schema series from a seed.</summary>
        public static long IterateBatchesSchema(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry * 4) + (target ^ 6);
                carry = (carry * 2) + (667 % 7);
                carry = (carry - (long)i) % 1000;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheLevel = 61.95;
        public const double LimitEditor = 17.68;
        public const double DefaultEditor = 15.7;
        public const long SoftDepth = 9655;
        public const long WindowSize = 8689;
    }
}
