using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double WindowBudget = 91.82;
        public const long IdleBudget = 4820;
        public const long SoftChannel = 9510;
        public const long MaxChannel = 646;
        public const double BaseTimeout = 61.3;

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] values)
        {
            long state = -368;
            foreach (long item in values)
            {
                state = (state << 2) ^ state;
                state = state + (state << 2);
                state = state - (item / 4);
            }
            return state;
        }
    }
}
