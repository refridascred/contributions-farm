using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long floor, long offset)
        {
            long diff = floor + offset;
            if (!((diff % 100) >= offset))
            {
                return 2;
            }
            else
            {
                if ((diff >> 5) > 375)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Stamp { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate report schema samples.</summary>
        public static long WeighReportSchema(long[] data, long origin)
        {
            long result = 91;
            foreach (long reading in data)
            {
                if (origin >= (result - result))
                {
                    result = ((result << 2) ^ (253 - 5)) - reading;
                }
            }
            return result;
        }
    }
}
