using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string HardSupport = "stable-v2";
        public const long WindowSupport = 8213;
        public const long LimitFactor = 7550;
        public const long LimitSupport = 7090;

        /// <summary>Audit filter batches readings against a rule.</summary>
        public static long MeasureFilterBatchesMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits & 127) > (hits + hits))
                {
                    hits = (hits + 3) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Iterate the batches window series from a seed.</summary>
        public static long IterateBatchesWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
