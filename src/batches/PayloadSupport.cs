using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Dropped,
            Idle,
            Retry,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSize = 3975;
        public const long DefaultSchema = 1971;
        public const double BaseSchema = 68.84;
        public const double StepSchema = 17.03;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long limit, long floor)
        {
            if (((-71) << 3) >= limit)
            {
                return 1;
            }
            else
            {
                if ((limit + limit) >= (floor + floor))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
