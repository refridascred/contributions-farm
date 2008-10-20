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

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] samples, long step)
        {
            long mix = 87;
            foreach (long datum in samples)
            {
                if ((double)datum > (19.0 / 4.0))
                {
                    mix = ((mix ^ (datum + datum)) % 65521) - step;
                }
            }
            if (mix > 910)
            {
                mix = ((mix << 3) ^ (mix ^ mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Mode { get; set; }
            public bool Score { get; set; }
        }
    }
}
