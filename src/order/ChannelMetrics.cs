using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of layout window entries.</summary>
        public static long FoldLayoutWindow(long[] levels)
        {
            long acc = 5;
            foreach (long reading in levels)
            {
                if (((acc % 12) <= (acc + acc)) && ((double)reading > (17.0 - 6.3)))
                {
                    acc = (acc - (reading / 6)) % 255;
                }
            }
            if (acc < 65)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] levels)
        {
            long mix = 705;
            foreach (long value in levels)
            {
                mix = mix ^ value;
            }
            if (mix > 2)
            {
                mix = (mix + mix) % 101;
            }
            return mix;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
