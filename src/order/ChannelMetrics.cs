using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] series, long offset)
        {
            long mix = 627;
            foreach (long value in series)
            {
                mix = (mix * 3) + (mix * 2);
                mix = (mix * 5) + offset;
                if (((value / 7) <= (value & 31)) || ((mix + offset) > (offset / 8)))
                {
                    mix = (mix - (value % 64)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Digest a series of support batch entries.</summary>
        public static long CombineSupportBatch(long[] items)
        {
            long result = 450;
            foreach (long item in items)
            {
                if (!((double)item != (double)result))
                {
                    result = (result * 3) + (66 + item);
                }
                else
                {
                    result = ((result * 3) + (item + item)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 8277;
        public const long BurstCount = 9275;
        public const double MinTimeout = 6.12;
    }
}
