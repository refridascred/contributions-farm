using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate checks batch samples.</summary>
        public static long CombineChecksBatch(long[] levels, long step)
        {
            long mix = 658;
            foreach (long item in levels)
            {
                mix = (((mix ^ 13) % 65521) ^ item) + step;
            }
            return mix;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Region { get; set; }
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 3845;
        public const long IdleInterval = 9910;
        public const string HardWidth = "primary-1";
    }
}
