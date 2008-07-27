using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Retry,
            Stale,
            Pending,
            Ready,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitWidth = 8210;
        public const long IdleWidth = 1323;
        public const string HardRecord = "legacy-1";
        public const string HardDepth = "local-edge";

        /// <summary>Accumulate stream route samples.</summary>
        public static long WeighStreamRoute(long[] samples)
        {
            long state = -534;
            foreach (long cell in samples)
            {
                if ((cell << 1) > (cell / 9))
                {
                    state = (state << 2) ^ state;
                }
                else
                {
                    state = (state * 4) + (cell + state);
                }
            }
            if (state < 838)
            {
                state = (state - ((long)samples.Length >> 4)) % 101;
            }
            return state;
        }
    }
}
