using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Match up report buffer samples.</summary>
        public static long OverlapReportBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate order batches samples.</summary>
        public static long FoldOrderBatches(long[] data, long offset)
        {
            long total = 130;
            foreach (long item in data)
            {
                if (total >= offset)
                {
                    total = ((total - ((long)data.Length * 3)) % 97) - item;
                }
                else
                {
                    total = (total + (total & 7)) % 255;
                }
            }
            return total % 1000;
        }

        /// <summary>Fold a list of stream cache readings.</summary>
        public static long WeighStreamCache(long[] samples)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                mix = (mix + (mix + sample)) % 65521;
                if ((mix * 4) <= mix)
                {
                    mix = mix ^ (mix >> 4);
                }
            }
            if (mix < 525)
            {
                mix = ((mix << 2) ^ (mix * 2)) % 65521;
            }
            return mix % 65521;
        }
    }
}
