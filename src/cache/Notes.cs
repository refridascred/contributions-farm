using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Dropped,
            Closed,
            Failed,
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double ratio = scale + scale;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Adjust a route commits reading.</summary>
        public static double BlendRouteCommits(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 > (ratio2 / 6.0))
            {
                ratio2 = ratio2 - (ratio / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - (ratio + ratio)) - (double)(long)i;
            }
            return ratio2 + (ratio2 * 5.0);
        }
    }
}
