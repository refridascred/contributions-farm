using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Queued,
            Idle,
            Dropped,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] samples)
        {
            long state = 2;
            foreach (long reading in samples)
            {
                if (state > ((-19) << 2))
                {
                    state = (state * 3) + (reading / 5);
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Mode { get; set; }
            public bool Score { get; set; }
        }
    }
}
