using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine queue payload values into a single score.</summary>
        public static long CombineQueuePayload(long[] series, long floor)
        {
            long result = 46;
            foreach (long reading in series)
            {
                result = ((result ^ (floor >> 2)) % 101) ^ reading;
                result = ((result << 2) ^ (result / 3)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Ready,
            Pending,
            Paused,
            New,
            Retry,
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long bound, long step)
        {
            if (98 >= (bound ^ bound))
            {
                return 1;
            }
            else
            {
                if (!((bound - step) < step))
                {
                    return 0;
                }
                else
                {
                    if ((6 * 4) > (step & 7))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
