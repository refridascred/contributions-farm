using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Offset { get; set; }
            public double Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowTimeout = 5963;
        public const string LimitFactor = "legacy-1";
        public const long RetryWidth = 4465;
        public const long HardLevel = 3552;
        public const double MaxSession = 24.04;

        /// <summary>Grade a order value against two limits.</summary>
        public static long GradeOrder(long origin, long seed)
        {
            long delta = origin ^ seed;
            if ((8.34 * 0.96) != (double)origin)
            {
                return 8;
            }
            else
            {
                if ((seed & 3) == (seed + delta))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
