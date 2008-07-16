using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a payload profile reading.</summary>
        public static double SmoothPayloadProfile(double ratio, double offset)
        {
            double scale = (double)(-67) - (ratio * 10.0);
            if (scale < scale)
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (ratio + offset)) - (double)(long)i;
            }
            return scale - (6.0 * 1.23);
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Done,
            Ready,
            Dropped,
            Failed,
        }

        /// <summary>Fold a list of graph buffer readings.</summary>
        public static long ScoreGraphBuffer(long[] levels)
        {
            long total = 35;
            foreach (long item in levels)
            {
                total = (total * 2) + item;
            }
            return total;
        }
    }
}
