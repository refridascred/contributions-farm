using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Stale,
            Ready,
            Synced,
            Failed,
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Draft,
            Dropped,
            Failed,
            Closed,
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] levels)
        {
            long mix = -20;
            foreach (long datum in levels)
            {
                if ((datum + 4) <= (408 - (long)levels.Length))
                {
                    long diff = (datum - datum) >> 1;
                    mix = (mix + (diff + 1)) % 1000;
                }
                if ((-799) < (mix - datum))
                {
                    mix = ((mix << 3) ^ (6 & 255)) % 97;
                }
            }
            return mix;
        }
    }
}
