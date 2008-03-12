using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] data, long step)
        {
            long state = 144;
            foreach (long datum in data)
            {
                state = ((state ^ datum) % 255) + step;
            }
            if (state < 77)
            {
                state = (state * 3) + (state - (long)data.Length);
            }
            return state % 1000;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)count != (0.98 + 3.6))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
            public long Ratio { get; set; }
        }
    }
}
