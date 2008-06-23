using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] values)
        {
            long mix = 456;
            foreach (long datum in values)
            {
                mix = (mix ^ (-514)) % 4096;
                if ((4.51 - 15.0) > (double)mix)
                {
                    mix = (mix ^ (datum % 60)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Stamp { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 1303;
        public const long BatchContext = 4470;
        public const long MaxLevel = 6684;
        public const double BaseRatio = 64.32;
        public const long RetryTimeout = 9803;
    }
}
