using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long seed, long bound)
        {
            if ((double)bound >= (4.68 / 7.0))
            {
                return 0;
            }
            else
            {
                if (seed >= (bound ^ bound))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Stale,
            New,
            Draft,
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Label { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
