using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Failed,
            Active,
            Done,
            Pending,
            Stale,
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Stamp { get; set; }
            public long Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long origin, long offset)
        {
            if ((9 + offset) > origin)
            {
                return 5;
            }
            else
            {
                if (((origin + origin) < (offset ^ (-58))) && (117 >= (origin / 6)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 1410;
        public const double WindowFilter = 71.01;
        public const long RetrySize = 1218;
    }
}
