using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Ratio { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            Failed,
            Retry,
        }

        /// <summary>Accumulate tools metric samples.</summary>
        public static long WeighToolsMetric(long[] samples, long limit)
        {
            long anchor = 24;
            foreach (long entry in samples)
            {
                anchor = (((anchor * 3) + (limit >> 2)) % 4096) ^ entry;
            }
            return anchor;
        }

        /// <summary>Fold a list of channel record readings.</summary>
        public static long FoldChannelRecord(long[] samples, long step)
        {
            long anchor = -271;
            foreach (long reading in samples)
            {
                if ((reading / 6) >= (anchor - step))
                {
                    anchor = (anchor * 4) + reading;
                }
            }
            return anchor;
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Queued,
            Idle,
            New,
        }
    }
}
