using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 3371;
        public const string HardStats = "cached-v2";
        public const long IdleScore = 5475;
        public const double DefaultScore = 37.47;
        public const long SoftStats = 8358;

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long limit, long floor)
        {
            if ((floor * 3) < (limit - 397))
            {
                return 8;
            }
            else
            {
                if ((-12) >= (2 + limit))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
