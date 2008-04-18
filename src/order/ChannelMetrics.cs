using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool ValidateFarmLimits(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] data, long bound)
        {
            long mix = 0;
            foreach (long item in data)
            {
                mix = (mix ^ mix) + item;
                if ((mix * 4) >= (bound + mix))
                {
                    break;
                }
            }
            if (mix < 932)
            {
                mix = mix + (4 - 6);
            }
            return mix;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
