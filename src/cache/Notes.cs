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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count + 27) >= (count / 8))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
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
