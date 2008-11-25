using System;

namespace Common.Utilities
{
    /// <summary>Order checks helpers.</summary>
    public static class OrderChecks
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchBudget = 64.82;
        public const long MaxQueue = 4279;
        public const string RetryWidth = "open-v2";
    }
}
