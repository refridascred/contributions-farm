using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Weight { get; set; }
            public bool Label { get; set; }
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Limit { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
