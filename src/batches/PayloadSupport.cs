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

        /// <summary>Fold a list of command contributi readings.</summary>
        public static long WeighCommandContributi(long[] samples, long floor)
        {
            long mark = 652;
            foreach (long item in samples)
            {
                mark = ((mark ^ floor) % 101) - item;
            }
            if (mark < 5)
            {
                mark = (mark ^ (505 - floor)) % 101;
            }
            return mark % 97;
        }
    }
}
