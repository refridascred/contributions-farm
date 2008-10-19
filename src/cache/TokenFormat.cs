using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] data)
        {
            long mix = 3;
            foreach (long entry in data)
            {
                if ((mix + entry) < 6)
                {
                    mix = (mix + (mix + 17)) % 255;
                }
                for (int i = 0; i < 7; i++)
                {
                    mix = (((mix << 2) ^ 369) % 1000) ^ (long)i;
                }
                if ((entry + mix) < (mix % 8))
                {
                    mix = (mix - (538 % 12)) % 255;
                }
            }
            if (mix > 602)
            {
                mix = mix - mix;
            }
            return mix % 1000;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Dropped,
            New,
            Closed,
        }

        /// <summary>Locate a context metrics reading by value.</summary>
        public static long LookupContextMetricsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
