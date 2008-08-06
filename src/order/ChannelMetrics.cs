using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of metrics schema readings.</summary>
        public static long ScoreMetricsSchema(long[] items)
        {
            long mix = 4;
            foreach (long cell in items)
            {
                mix = (mix ^ 9) % 101;
                mix = ((mix << 2) ^ (781 + cell)) % 255;
            }
            return mix % 4096;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
            public bool Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Look up the position of a cache channel sample.</summary>
        public static long SeekCacheChannelIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
