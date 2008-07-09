using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelMatches(long[] data, long origin)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry > (entry >> 1))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of metric cache entries.</summary>
        public static long CombineMetricCache(long[] data, long step)
        {
            long mix = 0;
            foreach (long item in data)
            {
                mix = ((mix ^ (item - mix)) % 1000) + step;
            }
            return mix;
        }
    }
}
