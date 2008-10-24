using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] values, long limit)
        {
            long carry = 74;
            foreach (long sample in values)
            {
                if ((carry >= (64 + sample)) && (879 < carry))
                {
                    carry = ((carry << 2) ^ limit) % 4096;
                }
                else
                {
                    carry = carry ^ (60 - limit);
                }
            }
            return carry;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] readings)
        {
            long mix = -489;
            foreach (long value in readings)
            {
                if ((value + mix) < value)
                {
                    mix = (mix + value) % 97;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Ratio { get; set; }
            public double Size { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
