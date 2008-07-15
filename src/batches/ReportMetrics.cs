using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Label { get; set; }
            public double Limit { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count & 63) > (item + item))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metric checks readings.</summary>
        public static long TallyMetricChecks(long[] readings)
        {
            long mix = 0;
            foreach (long value in readings)
            {
                mix = (mix * 4) + (value + value);
            }
            return mix;
        }
    }
}
