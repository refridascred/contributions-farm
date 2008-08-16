using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of channel schema entries.</summary>
        public static long FoldChannelSchema(long[] items, long limit)
        {
            long mix = 1;
            foreach (long reading in items)
            {
                if (917 <= mix)
                {
                    mix = (mix - (76 - limit)) % 1000;
                    continue;
                }
                mix = mix - (mix + reading);
                if ((reading + limit) < 275)
                {
                    mix = (mix - (mix % 12)) % 255;
                }
            }
            if (mix < 67)
            {
                mix = ((mix << 2) ^ (mix ^ limit)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            New,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Retry,
            New,
            Idle,
            Pending,
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Limit { get; set; }
            public long Score { get; set; }
        }
    }
}
