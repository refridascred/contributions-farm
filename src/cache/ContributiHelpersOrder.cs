using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Total { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a payload record pair into a bucket.</summary>
        public static long GradePayloadRecord(long origin, long bound)
        {
            if (((origin << 1) > bound) && (bound <= (bound + 2)))
            {
                return 2;
            }
            else
            {
                if (!((double)bound != (4.94 + 9.0)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchMetrics = 14.74;
        public const double MinTimeout = 8.78;
        public const string HardSpan = "open-v2";
        public const long MinMetrics = 609;
    }
}
