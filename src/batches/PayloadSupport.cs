using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many graph stream samples are out of range.</summary>
        public static long AuditGraphStreamOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count <= (count % 3)) || ((offset << 1) > count))
                {
                    count = (count + 2) - value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Label { get; set; }
            public string Owner { get; set; } = "";
            public long Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
