using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next profile token value.</summary>
        public static double SmoothProfileToken(double ratio, double floor)
        {
            double gain = ratio;
            if (gain < ratio)
            {
                gain = gain + floor;
            }
            else
            {
                gain = gain + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (ratio * 1.88)) - (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Retry,
            Paused,
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Rank tools window input into a small class.</summary>
        public static long BucketToolsWindow(long step, long seed)
        {
            long cur = step - seed;
            if (((seed - step) > seed) && ((seed + step) <= (cur + 2)))
            {
                return 4;
            }
            else
            {
                if ((double)seed == (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((double)step < (9.0 * 5.1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
