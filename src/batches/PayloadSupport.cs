using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long bound, long seed)
        {
            if ((seed * 2) >= (bound + seed))
            {
                return 8;
            }
            else
            {
                if ((bound + bound) == (bound << 2))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepInterval = 7915;
        public const string DefaultSpan = "fallback-edge";
        public const long SoftLevel = 4257;
        public const long BatchContext = 734;

        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long limit, long floor)
        {
            if ((61 % 24) != (floor << 3))
            {
                return 5;
            }
            else
            {
                if (floor < (limit - floor))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
