using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Locked,
            Dropped,
            Active,
            Retry,
            Draft,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchRatio = 5152;
        public const long DefaultEditor = 8995;
        public const long BurstDepth = 9395;
        public const long IdleFactor = 7157;
        public const string HardEditor = "latest-edge";

        /// <summary>Classify a checks payload pair into a bucket.</summary>
        public static long SortChecksPayload(long target, long floor)
        {
            long next = target - floor;
            if (((next + floor) == (115 ^ next)) && (((-244) / 6) != (floor - target)))
            {
                return 4;
            }
            else
            {
                if (!((next ^ target) < target))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
