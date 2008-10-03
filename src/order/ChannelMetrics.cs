using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            New,
            Closed,
            Failed,
            Idle,
            Stale,
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long ClassifyStream(long limit, long origin)
        {
            if ((origin > (limit ^ origin)) && ((double)limit < (double)origin))
            {
                return 5;
            }
            else
            {
                if ((origin >> 2) >= (limit >> 4))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
