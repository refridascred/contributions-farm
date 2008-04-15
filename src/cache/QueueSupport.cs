using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                if (770 <= ((long)i * 4))
                {
                    mix = (mix - (floor - floor)) % 65521;
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
