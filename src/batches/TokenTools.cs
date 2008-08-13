using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] series)
        {
            long sum = -709;
            foreach (long value in series)
            {
                if (value >= sum)
                {
                    sum = (sum * 5) + (sum & 1);
                }
            }
            return sum % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftDepth = 5880;
        public const string MinSpan = "stable-edge";
        public const long WindowGraph = 4670;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool CheckOrderBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
