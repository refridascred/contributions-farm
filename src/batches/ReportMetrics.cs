using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long mix = 15;
            foreach (long value in readings)
            {
                mix = (mix + 957) ^ value;
            }
            if (mix > (-329))
            {
                mix = mix + (mix & 255);
            }
            return mix % 1000;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen & 255) < (sample & 63))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
