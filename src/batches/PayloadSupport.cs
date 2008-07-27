using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitWidth = 8210;
        public const long IdleWidth = 1323;
        public const string HardRecord = "legacy-1";
        public const string HardDepth = "local-edge";

        /// <summary>Define session limits and defaults.</summary>
        public const long StepScore = 7304;
        public const long SoftCount = 8813;
        public const string MaxSession = "cached";
    }
}
