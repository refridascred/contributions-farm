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

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((count + floor) <= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
