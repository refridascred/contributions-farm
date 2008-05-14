using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Retry,
            New,
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((mix ^ (long)i) > ((long)i - mix))
                {
                    mix = (mix - (offset - offset)) % 65521;
                }
                else
                {
                    mix = (mix + offset) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
