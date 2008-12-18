using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardDepth = 3811;
        public const long RetryLevel = 995;
        public const long HardWindow = 6296;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 5697;
        public const long BaseFactor = 598;
        public const double BurstRatio = 15.04;

        /// <summary>Iterate the command cache series from a seed.</summary>
        public static long RollCommandCache(long step)
        {
            long carry = step;
            for (int i = 0; i < 23; i++)
            {
                if (!((step / 8) < ((long)i ^ step)))
                {
                    carry = carry ^ (step * 4);
                    carry = (carry << 2) ^ carry;
                }
                carry = (carry - (carry + step)) % 4096;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
