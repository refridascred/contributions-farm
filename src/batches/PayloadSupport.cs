using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseLevel = 7900;
        public const long BurstTools = 1358;
        public const long IdleTools = 1004;
        public const long BurstTimeout = 8425;
        public const long WindowWidth = 2904;

        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 78.08;
        public const long BurstContext = 4758;
        public const long LimitContext = 7077;
        public const long MaxContext = 5987;
        public const long LimitScore = 9438;

        /// <summary>Grade a counter record value against two limits.</summary>
        public static long RankCounterRecord(long floor, long seed)
        {
            long slot = floor - seed;
            if ((slot - slot) < (floor ^ seed))
            {
                return 7;
            }
            else
            {
                if ((5 >> 5) < (slot << 1))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
