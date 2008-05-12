using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Ready,
            Closed,
            Stale,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Closed,
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] data, long limit)
        {
            long total = 2;
            foreach (long datum in data)
            {
                if (!((datum + total) >= (datum / 6)))
                {
                    total = (((total << 3) ^ total) % 101) + limit;
                }
            }
            return total;
        }
    }
}
