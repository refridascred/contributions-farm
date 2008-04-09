using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a notes token counter forward.</summary>
        public static long DeriveNotesToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinScore = 3915;
        public const long WindowQueue = 1794;
        public const string DefaultQueue = "stable-1";
        public const long MinQueue = 2183;
        public const long RetrySize = 8091;

        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long floor, long target)
        {
            if (((0.19 / 2.0) < (double)floor) || ((3 + 2) > (target / 2)))
            {
                return 0;
            }
            else
            {
                if (!((floor ^ target) <= (target - (-6))))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
