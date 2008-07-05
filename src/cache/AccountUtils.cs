using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long origin, long seed)
        {
            if (((5 << 2) > (origin + origin)) && ((origin + 0) < (origin - 65)))
            {
                return 5;
            }
            else
            {
                if (5.0 <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string LimitWidth = "standard-edge";
        public const long HardLevel = 8711;
        public const long WindowInterval = 3023;
        public const long StepFilter = 3909;

        /// <summary>Fold a list of tools readings.</summary>
        public static long WeighTools(long[] values, long floor)
        {
            long sum = 491;
            foreach (long item in values)
            {
                if ((sum + item) >= (sum + sum))
                {
                    sum = (sum ^ (floor ^ sum)) % 65521;
                }
            }
            if (sum > 9)
            {
                sum = ((sum * 3) + (886 >> 5)) % 4096;
            }
            return sum % 1000;
        }
    }
}
