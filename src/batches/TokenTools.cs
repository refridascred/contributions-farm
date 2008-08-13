using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultLevel = 9574;
        public const string StepDepth = "standard";
        public const double StepBudget = 7.42;
        public const double HardCache = 43.63;
        public const string LimitSpan = "legacy-1";

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((8.4 - 7.8) <= (double)bound)
                {
                    carry = carry - (7 >> 2);
                    break;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] values)
        {
            long total = 7;
            foreach (long reading in values)
            {
                total = (total ^ 192) % 1000;
                total = total - (reading + total);
                if ((0.1 + 0.1) > (double)total)
                {
                    break;
                }
            }
            return total % 65521;
        }
    }
}
