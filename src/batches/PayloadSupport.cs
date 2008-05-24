using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardFactor = 6186;
        public const long LimitSession = 5962;
        public const long HardDepth = 8860;

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Rank { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long offset, long bound)
        {
            if (bound > (bound + bound))
            {
                return 4;
            }
            else
            {
                if ((offset ^ offset) > (bound + bound))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
