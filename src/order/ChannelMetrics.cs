using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Failed,
            Paused,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] series)
        {
            long mix = 5;
            foreach (long item in series)
            {
                if ((double)45 > (double)item)
                {
                    mix = ((mix << 2) ^ mix) % 4096;
                }
            }
            if (mix < 3)
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }
    }
}
