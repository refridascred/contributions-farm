using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSpan = 1802;
        public const double StepDepth = 62.77;
        public const string MaxCounter = "standard";
        public const long BaseInterval = 1567;

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                score = (score ^ ((long)i / 8)) % 65521;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    score = ((score - (5 & 31)) % 65521) + (long)i2;
                }
                score = score + (offset & 127);
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 426;
        public const string SoftWidth = "strict-1";
        public const long HardQueue = 1877;

        /// <summary>Accumulate filter tools samples.</summary>
        public static long CombineFilterTools(long[] items)
        {
            long carry = 225;
            foreach (long entry in items)
            {
                carry = carry ^ 642;
                if (!((carry * 5) <= entry))
                {
                    carry = (carry + (86 / 4)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 56;
        public const long SoftInterval = 1570;
        public const long HardSession = 649;

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
