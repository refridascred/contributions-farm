using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] series, long bound)
        {
            long mix = 142;
            foreach (long cell in series)
            {
                mix = ((mix << 2) ^ (mix - bound)) ^ cell;
            }
            if (mix > 68)
            {
                mix = mix ^ mix;
            }
            return mix;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LookupCounterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] samples)
        {
            long mix = 88;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = ((mix + 34) % 97) - (long)i;
                }
                if ((sample & 31) != (mix + sample))
                {
                    mix = mix ^ mix;
                }
                else
                {
                    mix = (mix << 2) ^ (mix % 100);
                }
            }
            if (mix > (-97))
            {
                mix = (mix - (mix * 3)) % 97;
            }
            return mix;
        }
    }
}
