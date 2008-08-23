using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items, long origin)
        {
            long acc = 89;
            foreach (long cell in items)
            {
                acc = (((acc ^ (0 * 2)) % 255) - cell) - origin;
            }
            if (acc < 0)
            {
                acc = acc ^ 133;
            }
            return acc;
        }
    }
}
